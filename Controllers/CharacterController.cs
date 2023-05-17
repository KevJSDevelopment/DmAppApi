using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using DMApp.Models;
using AutoMapper;
using DMApp.Data;
using DMApp.Dtos;
using DMApp.HelperClasses;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using DMApp.Utils;
using Newtonsoft.Json;

namespace DMApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepo _repository;
        private readonly IMapper _mapper;
        private readonly OpenAIAPI _api;

        public CharacterController(ICharacterRepo repository, IMapper mapper)
        {
            string? openai_key = Environment.GetEnvironmentVariable("OpenAI_Key");
            string? openai_org = Environment.GetEnvironmentVariable("OpenAi_Organization");
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

                return Ok(characterReadDtos); // Json(new { character });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { error = ex.Message });
            }
        }

        [HttpPost("/character-image")]
        public async Task<ActionResult> GenerateCharacterImages([FromBody] CharacterReadDto characterReadDto)
        {
            var image = await _api.ImageGenerations.CreateImageAsync(new OpenAI_API.Images.ImageGenerationRequest()
            {
                Prompt = Prompts.CreateCharacterImage(JsonConvert.SerializeObject(characterReadDto)),
                NumOfImages = 1,
                Size = OpenAI_API.Images.ImageSize._1024
            });

            return Ok(image);
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

