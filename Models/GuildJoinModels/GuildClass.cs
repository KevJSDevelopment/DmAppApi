using System;
using Discord;

namespace DMApp.Models
{
	public class GuildClass
	{
        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }

        public int? CharacterClassId { get; set; }
        public CharacterClass? CharacterClass { get; set; }
    }
}

