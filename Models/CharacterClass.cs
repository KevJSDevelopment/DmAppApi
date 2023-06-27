using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
	public class CharacterClass
	{
        public CharacterClass()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Features = new List<Feature>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int CharacterClassId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Feature> Features { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

