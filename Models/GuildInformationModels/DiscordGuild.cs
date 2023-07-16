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

        public void ValidateChannelConfiguration()
        {
            var characterAssetChannels = Channels.Count(c => c.isCharacterAssetChannel);
            var dmOnlyCharacterAssetChannels = Channels.Count(c => c.isCharacterAssetChannel && c.isDmOnlyChannel);

            if (characterAssetChannels >= 2 && dmOnlyCharacterAssetChannels < 1 || dmOnlyCharacterAssetChannels > 1)
            {
                throw new InvalidOperationException("You can only flag one channel as a character asset channel and one channel as a dm characters channel");
            }
        }

        public long GuildId { get; set; }

        public IList<DiscordGuildChannel> Channels { get; set; }

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
