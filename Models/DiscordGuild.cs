using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class DiscordGuild
    {
        public DiscordGuild()
        {
            Characters = new List<Character>();
            Campaigns = new List<Campaign>();
            CharacterClasses = new List<CharacterClass>();
            CharacterRaces = new List<CharacterRace>();
            Items = new List<Item>();
            Features = new List<Feature>();
            Traits = new List<Trait>();
            Organizations = new List<Organization>();
            Spells = new List<Spell>();
        }

        public long GuildId { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Campaign> Campaigns { get; set; }
        public IList<CharacterClass> CharacterClasses { get; set; }
        public IList<CharacterRace> CharacterRaces { get; set; }
        public IList<Item> Items { get; set; }
        public IList<Feature> Features { get; set; }
        public IList<Trait> Traits { get; set; }
        public IList<Organization> Organizations { get; set; }
        public IList<Spell> Spells { get; set; }

        // Other properties...
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
