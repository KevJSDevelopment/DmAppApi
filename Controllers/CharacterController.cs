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
using System.Diagnostics;

namespace DMApp.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepo _characterRepo;
        private readonly IClassRepo _classRepo;
        private readonly IRaceRepo _raceRepo;
        private readonly IMapper _mapper;
        private readonly OpenAIAPI _api;

        public CharacterController(ICharacterRepo characterRepo, IClassRepo classRepo, IRaceRepo raceRepo, IMapper mapper)
        {
            string? openai_key = Environment.GetEnvironmentVariable("OpenAI_Key");
            string? openai_org = Environment.GetEnvironmentVariable("OpenAi_Organization");
            _characterRepo = characterRepo;
            _classRepo = classRepo;
            _raceRepo = raceRepo;
            _mapper = mapper;
            _api = new OpenAIAPI(new APIAuthentication(openai_key, openai_org));
        }

        [HttpGet("/characters/{characterId}")]
        public ActionResult GetCharacterById(int characterId)
        {
            Character character = _characterRepo.GetCharacterById(characterId);

            CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);

            return Ok(characterReadDto);
        }


        [HttpPost("/characters/new/{guildId}")]
        public async Task<ActionResult<Character>> CreateCharacter([FromBody] CharacterCreateDto characterCreateDto, [FromQuery] long guildId = 1077311704985239684, [FromForm] int tokens = 250)
        {
            string message = Prompts.CreateCharacter(characterCreateDto);
            
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

                CharacterReadDto characterDto = JsonConvert.DeserializeObject<CharacterReadDto>(chatResponse.Choices[0].Message.Content);

                Character character = _mapper.Map<Character>(characterDto);

                character = _characterRepo.CreateCharacter(character, guildId);

                if (_characterRepo.SaveChanges())
                {
                    CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);
                }
                else
                {
                    RequestResponse response = new RequestResponse();
                    response.Status = 400;
                    response.Message = $"Failed to create character {character.Name}";

                    return BadRequest(error: JsonConvert.SerializeObject(response));
                }

                return Ok(characterDto); // Json(new { character });
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
            Character character = _characterRepo.GetCharacterById(characterId);

            return Ok(character);
        }

        [HttpGet("/characters/characterPDF/{characterId}")]
        public async Task<ActionResult> GetCharacterSheet(int characterId)
        {
            Character character = _characterRepo.GetCharacterById(characterId);

            CharacterReadDto characterReadDto = _mapper.Map<CharacterReadDto>(character);

            string pdfDataUri = await FileHelper.FillFormAsync(characterReadDto);

            return File(Convert.FromBase64String(pdfDataUri), "application/pdf", "CharacterSheet.pdf");
        }

        [HttpDelete("/characters/{characterId}")]
        public ActionResult DeleteCharacter(int characterId)
        {
            Character character = _characterRepo.GetCharacterById(characterId);
            string name = character.Name;

            _characterRepo.DeleteCharacter(character);

            RequestResponse response = new RequestResponse();
            if(_characterRepo.SaveChanges())
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

