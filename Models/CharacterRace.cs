using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Hosting;

namespace DMApp.Models
{
    public class CharacterRace
    {
        public CharacterRace()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Traits = new List<Trait>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        [Key]
        public int CharacterRaceId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Trait> Traits { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

