using DMApp.Models;

namespace DMApp.Data
{
    public class SqlSessionRepo : ISessionRepo
    {
        private readonly DMAppContext _context;

        public SqlSessionRepo(DMAppContext context)
        {
            _context = context;
        }

        public List<Session> GetSessions(int campaignid)
        {
            List<Session> Sessions = _context.Sessions.Where(s => s.CampaignId == campaignid).ToList(); 

            if(Sessions == null)
            {
                throw new ArgumentException(nameof(Sessions));
            }

            return Sessions;
        }

        public Session CreateSession(Session Session)
        {
            if (Session == null)
            {
                throw new ArgumentNullException(nameof(Session));
            }

            _context.Sessions.Add(Session);
            _context.SaveChanges();

            return Session;
        }

        public void DeleteSession(int SessionId)
        {
            Session Session = _context.Sessions.FirstOrDefault(c => c.Id == SessionId);

            if (Session == null)
            {
                throw new ArgumentNullException(nameof(Session));
            }

            _context.Sessions.Remove(Session);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}