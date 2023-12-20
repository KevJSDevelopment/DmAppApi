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

        private readonly IMapper _mapper;

        public FeatureConroller(IFeatureRepo featureRepo, IClassRepo classRepo, IMapper mapper)
        {
            _featureRepo = featureRepo;
            _classRepo = classRepo;
            _mapper = mapper;
        }

        [HttpPost("/features")]
        public ActionResult CreateFeature([FromBody] CharacterSheetPropertyDto featureDto, [FromForm] int classId)
        {
            Feature feature = _mapper.Map<Feature>(featureDto);

            CharacterClass characterClass = _classRepo.GetCharacterClassById(classId);

            if(characterClass != null)
            {
                feature.Class = characterClass;
                feature.ClassId = characterClass.CharacterClassId;
            }

            _featureRepo.CreateFeature(feature);

            return Ok("Feature Created");
        }
    }
}

