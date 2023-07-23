using System;
namespace DMApp.Models
{
	public class DiscordGuildChannel
	{
        public long ChannelId { get; set; }
        public string? ChannelName { get; set; }
        public string? ChannelType { get; set; }

        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }
    }
}

