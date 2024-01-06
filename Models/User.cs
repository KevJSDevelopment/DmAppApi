using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DMApp.Models
{
    public class User
    {
        public User()
        {
            Characters = new List<Character>();
            Campaigns = new List<Campaign>();

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Campaign> Campaigns { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}