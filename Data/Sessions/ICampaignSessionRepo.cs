using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ICampaignSessionRepo
    {
        bool SaveChanges();
        List<CampaignSession> GetSessions(int campaignId);
        CampaignSession CreateSession(CampaignSession Session);
        void DeleteSession(int SessionId);
    }
}