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
        public async Task<ActionResult<Character>> CreateCharacter([FromBody] CharacterReadDto _characterReadDto, [FromQuery] string description)
        {
            string propertyList = "";

            foreach (var property in _characterReadDto.GetType().GetProperties())
            {
                propertyList = propertyList + "," + property.Name + ": " + _characterReadDto.Name;
            }

            string message = Prompts.CreateCharacter(propertyList, description);

            try
            {
                ChatResult response = await _api.Chat.CreateChatCompletionAsync(new ChatRequest()
                {
                    Model = Model.ChatGPTTurbo,
                    Temperature = 0.1,
                    MaxTokens = 50,
                    Messages = new ChatMessage[] {
                        new ChatMessage(ChatMessageRole.User, message)
                    }
                });

                

                return Ok(response); // Json(new { character });
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

