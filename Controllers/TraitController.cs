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

        private readonly IMapper _mapper;

        public TraitConroller(ITraitRepo TraitRepo, IRaceRepo raceRepo, IMapper mapper)
        {
            _traitRepo = TraitRepo;
            _raceRepo = raceRepo;
            
            _mapper = mapper;
        }

        [HttpPost("/Traits")]
        public ActionResult CreateTrait([FromBody] CharacterSheetPropertyDto traitDto, [FromForm] int raceId)
        {
            

            Trait trait = _mapper.Map<Trait>(traitDto);
            

            CharacterRace characterRace = _raceRepo.GetCharacterRaceById(raceId);

            if(characterRace != null)
            {
                trait.Race = characterRace;
                trait.RaceId = characterRace.Id;
            }

            _traitRepo.CreateTrait(trait);

            return Ok("Trait Created");
        }
    }
}

