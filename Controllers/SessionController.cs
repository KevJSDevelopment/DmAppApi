using AutoMapper;
using DMApp.Data;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DMApp.Controllers
{
    public class SessionController : Controller
    {
        private readonly ISessionRepo _SessionRepo;

        public SessionController(ISessionRepo sessionRepo)
        {
            _SessionRepo = sessionRepo;
        }

        [HttpPost("/sessions")]
        public ActionResult CreateSession([FromBody] Session Session)
        {
            _SessionRepo.CreateSession(Session);

            return Ok("Session Created");
        }

        [HttpGet("/sessions/{campaignId}")]
        public ActionResult GetSessions(int campaignId)
        {
            List<Session> Sessions = _SessionRepo.GetSessions(campaignId);

            return Ok(Sessions);
        }
    }
}
