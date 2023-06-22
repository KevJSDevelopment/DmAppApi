using AutoMapper;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Data
{
    public class DiscordGuildController : Controller
    {
        private readonly IDiscordGuildRepo _repository;
        private readonly IMapper _mapper;

        public DiscordGuildController(IDiscordGuildRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("/guilds/characters/{guildId}")]
        public ActionResult GetCharactersByGuildId(long guildId = 1077311704985239700)
        {
            IList<Character> characters = _repository.GetCharactersByGuildId(guildId);

            return Ok(characters);
        }

        [HttpGet("/guilds/character-races/{guildId}")]
        public ActionResult<IList<CharacterRace>> GetCharacterRacesByGuildId(long guildId = 1077311704985239684)
        {
            IList<CharacterRace> characterRaces = _repository.GetCharacterRacesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> characterRaceDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterRaces);

            return Ok(characterRaceDtos);
        }

        [HttpGet("/guilds/character-classes/{guildId}")]
        public ActionResult<IList<CharacterClass>> GetClassesByGuildId(long guildId = 1077311704985239684)
        {
            IList<CharacterClass> characterClasses = _repository.GetCharacterClassesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> characterClassDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(characterClassDtos);
        }

        [HttpGet("/guilds/features/{guildId}")]
        public ActionResult<IList<Feature>> GetFeaturesByGuildId(long guildId = 1077311704985239684)
        {
            IList<Feature> characterClasses = _repository.GetFeaturesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> featureDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(featureDtos);
        }

        [HttpGet("/guilds/traits/{guildId}")]
        public ActionResult<IList<Trait>> GetTraitsByGuildId(long guildId = 1077311704985239684)
        {
            IList<Trait> characterClasses = _repository.GetTraitsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> traitDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(traitDtos);
        }

        [HttpGet("/guilds/organizations/{guildId}")]
        public ActionResult<IList<Organization>> GetOrganizationsByGuildId(long guildId = 1077311704985239684)
        {
            IList<Organization> characterClasses = _repository.GetOrganizationsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> organizationDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(organizationDtos);
        }

        [HttpGet("/guilds/items/{guildId}")]
        public ActionResult<IList<Item>> GetItemsByGuildId(long guildId = 1077311704985239684)
        {
            IList<Item> characterClasses = _repository.GetItemsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> itemDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(itemDtos);
        }

        [HttpGet("/guilds/spells/{guildId}")]
        public ActionResult<IList<Spell>> GetspellsByGuildId(long guildId = 1077311704985239684)
        {
            IList<Spell> characterClasses = _repository.GetSpellsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> spellDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(spellDtos);
        }

        [HttpPost("/guilds/{guildId}")]
        public ActionResult AddGuild(long guildId = 1077311704985239684)
        {
            DiscordGuild guild = _repository.CreateGuild(guildId);
            if (_repository.SaveChanges()) return Ok(guild);
            else return BadRequest(new { error = $"Unable to save guild: {guildId}" });
        }

        [HttpDelete("/guilds/{guildId}")]
        public ActionResult DeleteGuild(long guildId = 1077311704985239700)
        {
            _repository.DeleteGuild(guildId);

            if (_repository.SaveChanges()) return Ok(new {
                    status = 200,
                    message = $"Guild successfully deleted: {guildId}"
                }
            );
            else return BadRequest(new { error = $"Unable to delete guild: {guildId}" });
        }
    }
}