using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IChannelRepo
    {
        bool SaveChanges();
        DiscordGuildChannel CreateChannel(DiscordGuildChannel channel);
        DiscordGuildChannel GetChannelById(long ChannelId);
        void DeleteChannel(long channelId);
    }
}