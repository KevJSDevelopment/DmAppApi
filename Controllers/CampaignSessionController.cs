using AutoMapper;
using DMApp.Data;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class CampaignSessionController : Controller
    {
        private readonly ICampaignSessionRepo _sessionRepo;

        public CampaignSessionController(ICampaignSessionRepo sessionRepo)
        {
            _sessionRepo = sessionRepo;
        }

        [HttpPost("/sessions")]
        public ActionResult CreateSession([FromBody] CampaignSession campaignSession)
        {
            _sessionRepo.CreateSession(campaignSession);

            return Ok("Session Created");
        }

        [HttpGet("/sessions/{campaignId}")]
        public ActionResult GetSessions(int campaignId)
        {
            List<CampaignSession> campaignSessions = _sessionRepo.GetSessions(campaignId);

            return Ok(campaignSessions);
        }
    }
}
