using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DMApp.Models
{
    public class Item
    {
        public Item()
        {
            Name = string.Empty;
            Description = string.Empty;
            Cost = 0;
            Characters = new List<Character>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int ItemId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Cost { get; set; }

        public int? Range { get; set; }

        public string? Duration { get; set; }
        public string? AreaOfEffect { get; set; }
        public string? SavingThrow { get; set; }

        public string? DamageType { get; set; }

        public int? DamageDiceCount { get; set; }
        public int? DamageDiceValue { get; set; }

        // Other item properties
        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

