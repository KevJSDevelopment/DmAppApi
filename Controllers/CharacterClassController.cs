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
        private readonly IMapper _mapper;

        public CharacterClassConroller(IClassRepo classRepo, IMapper mapper)
        {
            _classRepo = classRepo;
            _mapper = mapper;
        }

        [HttpPost("/character-class")]
        public ActionResult CreateCharacterClass([FromBody] CharacterSheetPropertyDto characterClassDto)
        {
            CharacterClass characterClass = _mapper.Map<CharacterClass>(characterClassDto);

            _classRepo.CreateCharacterClass(characterClass);

            return Ok(new { Status = 200, message = "Class Created" });
        }
    }
}

