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
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public SpellConroller(ISpellRepo spellRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _spellRepo = spellRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/Spells/{guildId}")]
        public ActionResult CreateSpell([FromBody] CharacterSheetPropertyDto spellDto,long guildId = 0)
        {
            if (guildId == 0)
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out guildId);
            }

            Spell spell = _mapper.Map<Spell>(spellDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            spell.Guilds.Add(guild);

            _spellRepo.CreateSpell(spell);

            return Ok("Spell Created");
        }
    }
}

