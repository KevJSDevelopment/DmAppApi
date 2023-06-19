using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace DMApp.Models
{
    public class Trait
    {
        public Trait ()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Races = new List<CharacterRace>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        [Key]
        public int TraitId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<CharacterRace> Races { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

