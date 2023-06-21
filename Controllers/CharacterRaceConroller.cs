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
	public class CharacterRaceConroller : Controller
	{
        private readonly IRaceRepo _raceRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public CharacterRaceConroller(IRaceRepo raceRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _raceRepo = raceRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpGet("/character-race/{guildId}")]
        public ActionResult<IList<CharacterRace>> GetCharacterRacesByGuildId(long guildId = 1077311704985239684)
        {
            IList<CharacterRace> characterRaces = _raceRepo.GetCharacterRacesByGuildId(guildId);
            IList<CharacterRaceDto> characterRaceDtos = _mapper.Map<IList<CharacterRaceDto>>(characterRaces);

            return Ok(characterRaceDtos);
        }

        [HttpPost("/character-race/{guildId}")]
        public ActionResult CreateCharacterRace([FromBody] CharacterRaceDto characterRaceDto, long guildId = 1077311704985239684)
        {
            CharacterRace characterRace = _mapper.Map<CharacterRace>(characterRaceDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if(guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            characterRace.Guilds.Add(guild);

            _raceRepo.CreateCharacterRace(characterRace);

            return Ok("Race Created");
        }
    }
}

