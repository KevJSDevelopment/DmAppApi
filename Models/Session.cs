using System;
namespace DMApp.Models
{
    public class Session
    {
        public Session()
        {

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int SessionId { get; set; }
        public string? Name { get; set; }
        public int? SessionNumber { get; set; }

        public int? CampaignId { get; set; }
        public Campaign? Campaign { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

