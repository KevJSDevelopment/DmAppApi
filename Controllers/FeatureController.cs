using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class FeatureConroller : Controller
	{
        private readonly IFeatureRepo _featureRepo;
        private readonly IClassRepo _classRepo;
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public FeatureConroller(IFeatureRepo featureRepo, IClassRepo classRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _featureRepo = featureRepo;
            _classRepo = classRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/features/{guildId}")]
        public ActionResult CreateFeature([FromBody] CharacterSheetPropertyDto featureDto, [FromForm] int classId,long guildId = 0)
        {
            if (guildId == 0)
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out guildId);
            }

            Feature feature = _mapper.Map<Feature>(featureDto);
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            CharacterClass characterClass = _classRepo.GetCharacterClassById(classId);

            if(characterClass != null)
            {
                feature.Class = characterClass;
                feature.ClassId = characterClass.CharacterClassId;
            }

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            feature.Guilds.Add(guild);

            _featureRepo.CreateFeature(feature);

            return Ok("Feature Created");
        }
    }
}

