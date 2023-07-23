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
        private readonly IDiscordGuildRepo _guildRepo;
        private readonly IMapper _mapper;

        public CampaignController(ICharacterRepo characterRepo, ICampaignRepo campaignRepo, IDiscordGuildRepo guildRepo, IMapper mapper)
        {
            _characterRepo = characterRepo;
            _campaignRepo = campaignRepo;
            _guildRepo = guildRepo;
            _mapper = mapper;
        }

        [HttpPost("/campaigns/{guildId}")]
        public ActionResult CreateCampaign([FromBody] Campaign campaign, long guildId)
        {
            DiscordGuild guild = _guildRepo.GetGuildByGuildId(guildId);

            if (guild == null)
            {
                guild = _guildRepo.CreateGuild(guildId);
            }

            guild.Campaigns.Add(campaign);

            _campaignRepo.CreateCampaign(campaign);

            return Ok("Campaign Created");
        }
    }
}

