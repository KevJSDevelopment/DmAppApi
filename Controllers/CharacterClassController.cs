using Microsoft.AspNetCore.Mvc;
using DMApp.Models;
using AutoMapper;
using DMApp.Data;
using DMApp.Dtos;
using DMApp.HelperClasses;
using DMApp.Utils;
using Newtonsoft.Json;

namespace DMApp.Controllers
{
	public class CharacterClassConroller : Controller
	{
        private readonly IClassRepo _classRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public CharacterClassConroller(IClassRepo classRepo,IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _classRepo = classRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpGet("/character-class/{guildId}")]
        public ActionResult<IList<CharacterClass>> GetClassesByGuildId(long guildId = 1077311704985239684)
        {
            IList<CharacterClass> characterClasses = _classRepo.GetClassesByGuildId(guildId);
            IList<CharacterClassDto> characterClassDtos = _mapper.Map<IList<CharacterClassDto>>(characterClasses);

            return Ok(characterClassDtos);
        }

        [HttpPost("/character-class/{guildId}")]
        public ActionResult CreateCharacterClass([FromBody] CharacterClassDto characterClassDto, long guildId = 1077311704985239684)
        {
            CharacterClass characterClass = _mapper.Map<CharacterClass>(characterClassDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            characterClass.Guilds.Add(guild);

            _classRepo.CreateClass(characterClass);

            return Ok("Class Created");
        }
    }
}

