using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlCampaignRepo : ICampaignRepo
    {
        private readonly DMAppContext _context;

        public SqlCampaignRepo(DMAppContext context)
        {
            _context = context;
        }

        public List<Campaign> GetCampaigns(int userId)
        {
            List<Campaign> campaigns = _context.Campaigns.ToList();

            if(campaigns == null)
            {
                throw new ArgumentException(nameof(campaigns));
            }

            return campaigns;
        }

        public Campaign CreateCampaign(Campaign campaign)
        {
            if (campaign == null)
            {
                throw new ArgumentNullException(nameof(campaign));
            }

            _context.Campaigns.Add(campaign);
            _context.SaveChanges();

            return campaign;
        }

        public void DeleteCampaign(int campaignId)
        {
            Campaign campaign = _context.Campaigns.FirstOrDefault(c => c.CampaignId == campaignId);

            if (campaign == null)
            {
                throw new ArgumentNullException(nameof(campaign));
            }

            _context.Campaigns.Remove(campaign);
        }

        public Campaign GetCampaignById(int campaignId)
        {
            return _context.Campaigns.FirstOrDefault(c => c.CampaignId == campaignId);
        }

        public void AddCharacterToCampaign(int campaignId, int characterId)
        {
            Campaign campaign = _context.Campaigns.FirstOrDefault(c => c.CampaignId == campaignId);

            Character character = _context.Characters.FirstOrDefault(c => c.CharacterId == characterId);

            if(campaign == null || character == null)
            {
                return;
            }

            campaign.Characters.Add(character);
            _context.SaveChanges();

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}