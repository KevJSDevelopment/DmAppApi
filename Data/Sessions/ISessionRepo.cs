using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ISessionRepo
    {
        bool SaveChanges();
        List<Session> GetSessions(int campaignId);
        Session CreateSession(Session Session);
        void DeleteSession(int SessionId);
    }
}