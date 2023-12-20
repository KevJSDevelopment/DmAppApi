using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class CharacterRaceConroller : Controller
	{
        private readonly IRaceRepo _raceRepo;
        private readonly IMapper _mapper;

        public CharacterRaceConroller(IRaceRepo raceRepo, IMapper mapper)
        {
            _raceRepo = raceRepo;
            _mapper = mapper;
        }

        [HttpPost("/character-race")]
        public ActionResult CreateCharacterRace([FromBody] CharacterSheetPropertyDto characterRaceDto)
        {
            CharacterRace characterRace = _mapper.Map<CharacterRace>(characterRaceDto);

            _raceRepo.CreateCharacterRace(characterRace);

            return Ok(new { Status = 200, message = "Race Created" });
        }
    }
}

