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
        public ActionResult CreateCharacterClass([FromBody] CharacterSheetPropertyDto characterClassDto,long guildId = 0)
        {
            if (guildId == 0)
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out guildId);
            }

            CharacterClass characterClass = _mapper.Map<CharacterClass>(characterClassDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            characterClass.Guilds.Add(guild);

            _classRepo.CreateCharacterClass(characterClass, guildId);

            return Ok("Class Created");
        }
    }
}

