using DMApp.Models;
using System.Xml.Linq;

namespace DMApp.Data
{
    public class SqlCampaignSessionRepo : ICampaignSessionRepo
    {
        private readonly DMAppContext _context;

        public SqlCampaignSessionRepo(DMAppContext context)
        {
            _context = context;
        }

        public List<CampaignSession> GetSessions(int campaignid)
        {
            List<CampaignSession> campaignSessions = _context.CampaignSessions.Where(s => s.CampaignId == campaignid).OrderBy(s => s.ScheduledStart).ToList(); 

            if(campaignSessions == null)
            {
                throw new ArgumentException(nameof(campaignSessions));
            }

            return campaignSessions;
        }

        public CampaignSession CreateSession(CampaignSession campaignSession)
        {
            if (campaignSession == null)
            {
                throw new ArgumentNullException(nameof(campaignSession));
            }

            _context.CampaignSessions.Add(campaignSession);
            _context.SaveChanges();

            return campaignSession;
        }

        public void DeleteSession(int SessionId)
        {
            CampaignSession campaignSession = _context.CampaignSessions.FirstOrDefault(c => c.Id == SessionId);

            if (campaignSession == null)
            {
                throw new ArgumentNullException(nameof(campaignSession));
            }

            _context.CampaignSessions.Remove(campaignSession);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}