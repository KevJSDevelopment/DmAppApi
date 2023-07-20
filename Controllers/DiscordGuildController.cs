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

        [HttpGet("/guilds/campaigns/{guildId}")]
        public ActionResult GetCampaignsByGuildId(long guildId)
        {
            IList<Campaign> campaigns = _repository.GetCampaignsByGuildId(guildId);

            return Ok(campaigns);
        }

        [HttpGet("/guilds/characters/{guildId}")]
        public ActionResult GetCharactersByGuildId(long guildId)
        {
            IList<Character> characters = _repository.GetCharactersByGuildId(guildId);

            return Ok(characters);
        }

        [HttpGet("/guilds/character-races/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetCharacterRacesByGuildId(long guildId)
        {
            IList<CharacterRace> characterRaces = _repository.GetCharacterRacesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> characterRaceDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterRaces);

            return Ok(characterRaceDtos);
        }

        [HttpGet("/guilds/character-classes/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetClassesByGuildId(long guildId)
        {
            IList<CharacterClass> characterClasses = _repository.GetCharacterClassesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> characterClassDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(characterClassDtos);
        }

        [HttpGet("/guilds/features/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetFeaturesByGuildId(long guildId)
        {
            IList<Feature> characterClasses = _repository.GetFeaturesByGuildId(guildId);
            IList<CharacterSheetPropertyDto> featureDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(featureDtos);
        }

        [HttpGet("/guilds/traits/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetTraitsByGuildId(long guildId)
        {
            IList<Trait> characterClasses = _repository.GetTraitsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> traitDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(traitDtos);
        }

        [HttpGet("/guilds/organizations/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetOrganizationsByGuildId(long guildId)
        {

            IList<Organization> characterClasses = _repository.GetOrganizationsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> organizationDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(organizationDtos);
        }

        [HttpGet("/guilds/items/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetItemsByGuildId(long guildId)
        {
            

            IList<Item> characterClasses = _repository.GetItemsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> itemDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(itemDtos);
        }

        [HttpGet("/guilds/spells/{guildId}")]
        public ActionResult<IList<CharacterSheetPropertyDto>> GetspellsByGuildId(long guildId)
        {
            

            IList<Spell> characterClasses = _repository.GetSpellsByGuildId(guildId);
            IList<CharacterSheetPropertyDto> spellDtos = _mapper.Map<IList<CharacterSheetPropertyDto>>(characterClasses);

            return Ok(spellDtos);
        }

        [HttpGet("/guilds/assets/character-channel/{guildId}")]
        public ActionResult<DiscordGuildChannel> GetCharacterAssetChannelByGuildId(long guildId)
        {
            DiscordGuildChannel channel = _repository.GetCharacterAssetChannelByGuildId(guildId);

            return Ok(channel);
        }

        [HttpPost("/guilds/{guildId}")]
        public ActionResult AddGuild(long guildId)
        {
            DiscordGuild guild = _repository.CreateGuild(guildId);
            if (_repository.SaveChanges()) return Ok(guild);
            else return BadRequest(new { error = $"Unable to save guild: {guildId}" });
        }

        [HttpDelete("/guilds/{guildId}")]
        public ActionResult DeleteGuild(long guildId)
        {
            if(guildId == null || guildId == 0) return BadRequest(new { error = $"Unable to delete guild: {guildId}" });

            _repository.DeleteGuild(guildId);

            if (_repository.SaveChanges()) return Ok(new { status = 200,Message = $"Guild successfully deleted: {guildId}" });

            return BadRequest(new { error = $"Unable to delete guild: {guildId}" });
        }
    }
}