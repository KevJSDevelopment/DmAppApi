using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DMApp.Models
{
	public class Campaign
	{
        public Campaign()
        {
            Characters = new List<Character>();
            Sessions = new List<Session>();

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

		public int CampaignId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Session> Sessions { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

