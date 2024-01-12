using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DMApp.Models
{
	public class Campaign
	{
        public Campaign()
        {
            Characters = new List<Character>();
            CampaignSessions = new List<CampaignSession>();
            Users = new List<User>();

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

		public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<CampaignSession> CampaignSessions { get; set; }
        public IList<User> Users { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

