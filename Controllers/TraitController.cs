using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class TraitConroller : Controller
	{
        private readonly ITraitRepo _traitRepo;
        private readonly IRaceRepo _raceRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public TraitConroller(ITraitRepo TraitRepo, IRaceRepo raceRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _traitRepo = TraitRepo;
            _raceRepo = raceRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/Traits/{guildId}")]
        public ActionResult CreateTrait([FromBody] CharacterSheetPropertyDto traitDto, [FromForm] int raceId,long guildId)
        {
            

            Trait trait = _mapper.Map<Trait>(traitDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            CharacterRace characterRace = _raceRepo.GetCharacterRaceById(raceId);

            if(characterRace != null)
            {
                trait.Race = characterRace;
                trait.RaceId = characterRace.CharacterRaceId;
            }

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            trait.Guilds.Add(guild);

            _traitRepo.CreateTrait(trait);

            return Ok("Trait Created");
        }
    }
}

