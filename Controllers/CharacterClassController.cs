using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost("/character-class/{guildId}")]
        public ActionResult CreateCharacterClass([FromBody] CharacterSheetPropertyDto characterClassDto, long guildId = 1077311704985239684)
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

