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
        private readonly ICharacterRepo _characterRepo;
        private readonly IClassRepo _classRepo;
        private readonly IRaceRepo _raceRepo;
        private readonly ICampaignRepo _campaignRepo;
        private readonly IMapper _mapper;
        private readonly OpenAIAPI _api;

        public CharacterController(ICharacterRepo characterRepo, IClassRepo classRepo, IRaceRepo raceRepo, ICampaignRepo campaignRepo, IMapper mapper)
        {
            string? openai_key = Environment.GetEnvironmentVariable("OpenAI_Key");
            string? openai_org = Environment.GetEnvironmentVariable("OpenAi_Organization");
            _characterRepo = characterRepo;
            _classRepo = classRepo;
            _raceRepo = raceRepo;
            _campaignRepo = campaignRepo;
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


        [HttpPost("/characters/new")]
        public async Task<ActionResult<Character>> CreateCharacter([FromBody] CharacterInitiateDto characterInitiateDto, int tokens = 250)
        {
            string message = new Prompts(_mapper).CreateCharacter(characterInitiateDto, tokens);

            ChatResult chatResponse;

            List<ChatMessage> conversation = new List<ChatMessage>
            {
                new ChatMessage(ChatMessageRole.User, message)
            };

            CharacterReadDto characterReadGPTDto = new CharacterReadDto();

            chatResponse = await _api.Chat.CreateChatCompletionAsync(new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.1,
                MaxTokens = tokens,
                Messages = conversation.ToArray()
            });

            characterReadGPTDto = JsonConvert.DeserializeObject<CharacterReadDto>(chatResponse.Choices[0].Message.Content);

            CharacterCreateDto characterCreatedDto = _mapper.Map<CharacterCreateDto>(characterReadGPTDto);
            CharacterClass characterClass = _classRepo.GetCharacterClassByName(characterReadGPTDto.Class);
            CharacterRace characterRace = _raceRepo.GetCharacterRaceByName(characterReadGPTDto.Race);

            /* Add if users can create classes and races *
             * if (characterClass == null)
            {
                characterClass = new CharacterClass { Name = characterReadGPTDto.Class, Description = "" };
                // Create the character class
                characterClass = _classRepo.CreateCharacterClass(characterClass, guildId);

                // Add the guild to the character class
                characterClass.Guilds.Add(guild);

                // Add the character class to the guild
                guild.CharacterClasses.Add(characterClass);

                // Update the guild in the database
                _guildRepo.UpdateGuild(guild);

            }

            if (characterRace == null)
            {
                characterRace = new CharacterRace { Name = characterReadGPTDto.Race, Description = "" };
                // Create the character class
                characterRace = _raceRepo.CreateCharacterRace(characterRace, guildId);

                // Add the guild to the character class
                characterRace.Guilds.Add(guild);

                // Add the character class to the guild
                guild.CharacterRaces.Add(characterRace);

                // Update the guild in the database
                _guildRepo.UpdateGuild(guild);

            }
            */

            Character character = _mapper.Map<Character>(characterCreatedDto);

            if (characterClass != null) {
                character.Classes.Add(characterClass);
            }

            if (characterRace != null)
            {
                character.Race = characterRace;
                character.RaceId = characterRace.CharacterRaceId;
            }

            character = _characterRepo.CreateCharacter(character);

            if (_characterRepo.SaveChanges())
            {
                if (characterInitiateDto.CampaignId.HasValue) _campaignRepo.AddCharacterToCampaign(characterInitiateDto.CampaignId.Value, character.CharacterId);

                return Ok(new { Status = 200, data = character, message = $"{character.Name} successfully created" });
            }
            else
            {
                RequestResponse response = new RequestResponse();
                response.Status = 400;
                response.Message = $"Failed to create character {character.Name}";

                return BadRequest(error: JsonConvert.SerializeObject(response));
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

