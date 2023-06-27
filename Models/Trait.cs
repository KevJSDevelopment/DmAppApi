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
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int TraitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? RaceId { get; set; }
        public CharacterRace? Race { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

