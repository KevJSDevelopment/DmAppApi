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
using RestSharp;
using Discord.Net.Rest;

namespace DMApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepo _repository;
        private readonly IMapper _mapper;
        private readonly OpenAIAPI _api;
        private readonly string? _neural_love_token;

        public CharacterController(ICharacterRepo repository, IMapper mapper)
        {
            string? openai_key = Environment.GetEnvironmentVariable("OpenAI_Key");
            string? openai_org = Environment.GetEnvironmentVariable("OpenAi_Organization");
            _repository = repository;
            _mapper = mapper;
            _api = new OpenAIAPI(new APIAuthentication(openai_key, openai_org));
        }

        [HttpGet("/characters/{characterId}")]
        public ActionResult GetCharacterById(int characterId)
        {
            Character character = _repository.GetCharacterById(characterId);

            CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);

            return Ok(characterReadDto);
        }


        [HttpPost("/characters/new")]
        public async Task<ActionResult<Character>> GenerateCharacters([FromBody] CharacterReadDto _characterReadDto, [FromForm] int tokens = 250)
        {
            string properties = JsonConvert.SerializeObject(_characterReadDto);

            string message = Prompts.CreateCharacter(properties);
            
            try
            {
                ChatResult chatResponse = await _api.Chat.CreateChatCompletionAsync(new ChatRequest()
                {
                    Model = Model.ChatGPTTurbo,
                    Temperature = 0.1,
                    MaxTokens = tokens,
                    Messages = new ChatMessage[] {
                        new ChatMessage(ChatMessageRole.User, message)
                    }
                });

                IList<CharacterReadDto> characterReadDtos = new List<CharacterReadDto>();

                foreach(ChatChoice choice in chatResponse.Choices)
                {
                    Character character = JsonConvert.DeserializeObject<Character>(choice.Message.Content);

                    character = _repository.CreateCharacter(character);
                    if (_repository.SaveChanges())
                    {
                        CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);
                        characterReadDtos.Add(characterReadDto);
                    }
                    else
                    {
                        RequestResponse response = new RequestResponse();
                        response.Status = 500;
                        response.Message = $"Failed to create character {character.Name}";

                        return BadRequest(error: JsonConvert.SerializeObject(response));
                    }
                }

                return Ok(characterReadDtos); // Json(new { character });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Json(new { error = ex.Message });
            }
        }

        [HttpPatch("/characters/{characterId}")] // update this
        public ActionResult SaveCharacterImage(int characterId, int tokenId)
        {
            Character character = _repository.GetCharacterById(characterId);

            return Ok(character);
        }

        [HttpGet("/characters/characterPDF/{characterId}")]
        public async Task<ActionResult> GetCharacterSheet(int characterId)
        {
            Character character = _repository.GetCharacterById(characterId);

            CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);

            string pdfDataUri = await FileHelper.FillFormAsync(characterReadDto);

            return File(Convert.FromBase64String(pdfDataUri), "application/pdf", "CharacterSheet.pdf");
        }

        [HttpDelete("/characters/{characterId}")]
        public ActionResult DeleteCharacter(int characterId)
        {
            Character character = _repository.GetCharacterById(characterId);
            string name = character.Name;

            _repository.DeleteCharacter(character);

            RequestResponse response = new RequestResponse();
            if(_repository.SaveChanges())
            {
                response.Status = 200;
                response.Message = $"{name} was deleted";
            }
            else
            {
                response.Status = 500;
                response.Message = $"Failed to delete character {name}";
            }

            return Ok(response);
        }
    }
}

