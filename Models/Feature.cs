using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;

namespace DMApp.Models
{
    public class Feature
    {
        public Feature()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? ClassId { get; set; }
        public CharacterClass? Class { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
