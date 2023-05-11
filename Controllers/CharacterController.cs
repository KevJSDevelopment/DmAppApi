using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using DMApp.Models;
using AutoMapper;
using DMApp.Data;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.AcroForms;
using System.Net.Http;
using System.Threading.Tasks;
using DMApp.Dtos;
using DMApp.HelperClasses;
using OpenAI_API.Completions;
using OpenAI_API.Chat;
using Microsoft.Extensions.Configuration;
using OpenAI_API.Models;
using System.IO;
using DMApp.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace DMApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepo _repository;
        private readonly IMapper _mapper;
        private readonly OpenAIAPI _api;

        public CharacterController(ICharacterRepo repository, IMapper mapper, IConfiguration configuration)
        {
            string? openai_key = configuration.GetValue<string>("OpenAI_Key");
            string? openai_org = configuration.GetValue<string>("OpenAi_Organization");
            _repository = repository;
            _mapper = mapper;
            _api = new OpenAIAPI(new APIAuthentication(openai_key, openai_org));
        }

        [HttpPost("/new-character")]
        public async Task<ActionResult<Character>> GenerateCharacters([FromBody] CharacterReadDto _characterReadDto, [FromQuery] string description, [FromForm] int tokens = 250)
        {
            string properties = JsonConvert.SerializeObject(_characterReadDto);

            string message = Prompts.CreateCharacter(properties, description);
            
            try
            {
                ChatResult response = await _api.Chat.CreateChatCompletionAsync(new ChatRequest()
                {
                    Model = Model.ChatGPTTurbo,
                    Temperature = 0.1,
                    MaxTokens = tokens,
                    Messages = new ChatMessage[] {
                        new ChatMessage(ChatMessageRole.User, message)
                    }
                });

                ICollection<CharacterReadDto> characterReadDtos = new List<CharacterReadDto>();

                foreach(ChatChoice choice in response.Choices)
                {
                    characterReadDtos.Add(JsonConvert.DeserializeObject<CharacterReadDto>(choice.Message.Content));
                }

                var client = new RestClient("https://cloud.leonardo.ai/api/rest/v1/generations");
                var request = new RestRequest("POST");
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", "{\"prompt\":\"An oil painting of a cat\",\"negative_prompt\":\"string\",\"modelId\":\"6bef9f1b-29cb-40c7-b9df-32b51c1f67d3\",\"sd_version\":\"v1_5\",\"num_images\":0,\"width\":512,\"height\":512,\"num_inference_steps\":0,\"guidance_scale\":0,\"init_generation_image_id\":\"string\",\"init_image_id\":\"string\",\"init_strength\":0,\"scheduler\":\"KLMS\",\"presetStyle\":\"LEONARDO\",\"tiling\":true,\"public\":true,\"promptMagic\":true,\"controlNet\":true,\"controlNetType\":\"POSE\"}", ParameterType.RequestBody);
                RestResponse leoResponse = client.Execute(request);

                return Ok(characterReadDtos); // Json(new { character });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { error = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult SaveCharacter([FromBody] CharacterReadDto _characterReadDto)
        {
            Character character = _mapper.Map<Character>(_characterReadDto);
            _repository.CreateCharacter(character);

            RequestResponse response = new RequestResponse();

            response.Status = 200;
            response.Message = $"Character{_characterReadDto.Name} created";

            return Ok(response); 
        }

        [HttpPost]
        public async Task<ActionResult> GetCharacterSheet([FromBody] CharacterReadDto _characterReadDto)
        {
            string pdfDataUri = await FileHelper.FillFormAsync(_characterReadDto);

            return File(Convert.FromBase64String(pdfDataUri), "application/pdf", "CharacterSheet.pdf");
        }
    }
}

