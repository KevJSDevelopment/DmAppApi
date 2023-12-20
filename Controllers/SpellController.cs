using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class SpellConroller : Controller
	{
        private readonly ISpellRepo _spellRepo;

        private readonly IMapper _mapper;

        public SpellConroller(ISpellRepo spellRepo, IMapper mapper)
        {
            _spellRepo = spellRepo;
            
            _mapper = mapper;
        }

        [HttpPost("/Spells")]
        public ActionResult CreateSpell([FromBody] CharacterSheetPropertyDto spellDto)
        {
            Spell spell = _mapper.Map<Spell>(spellDto);

            _spellRepo.CreateSpell(spell);

            return Ok("Spell Created");
        }
    }
}

