using AutoMapper;
using DMApp.Data;
using DMApp.Dtos.CharacterSheetPropertyDto;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class CampaignController : Controller
	{
        private readonly ICharacterRepo _characterRepo;
        private readonly ICampaignRepo _campaignRepo;
        private readonly IMapper _mapper;

        public CampaignController(ICharacterRepo characterRepo, ICampaignRepo campaignRepo, IMapper mapper)
        {
            _characterRepo = characterRepo;
            _campaignRepo = campaignRepo;
            _mapper = mapper;
        }

        [HttpPost("/campaigns")]
        public ActionResult CreateCampaign([FromBody] Campaign campaign)
        {
            _campaignRepo.CreateCampaign(campaign);

            return Ok("Campaign Created");
        }

        [HttpGet("/campaigns/{userId}")]
        public ActionResult GetCampaigns(int userId) 
        {
            List<Campaign> campaigns = _campaignRepo.GetCampaigns(userId);

            return Ok(campaigns); 
        }
    }
}

