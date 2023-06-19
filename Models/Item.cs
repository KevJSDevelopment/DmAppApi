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

        [Key]
        public int ItemId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int? Cost { get; set; }

        // Other item properties
        public IList<Character> Characters { get; set; } = new List<Character>();
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

