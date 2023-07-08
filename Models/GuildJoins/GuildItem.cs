using System;
namespace DMApp.Models
{
	public class GuildItem
	{
        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }

        public int? ItemId { get; set; }
        public Item? Item { get; set; }
    }
}

