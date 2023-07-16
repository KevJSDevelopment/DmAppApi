using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ICampaignRepo
    {
        bool SaveChanges();
        Campaign CreateCampaign(Campaign campaign);
        void AddCharacterToCampaign(int campaignId, int characterId);
        void DeleteCampaign(int campaignId);
    }
}