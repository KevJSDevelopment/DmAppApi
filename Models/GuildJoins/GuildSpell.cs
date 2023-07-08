using System;
namespace DMApp.Models
{
	public class GuildSpell
	{
        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }

        public int? SpellId { get; set; }
        public Spell? Spell { get; set; }
    }
}

