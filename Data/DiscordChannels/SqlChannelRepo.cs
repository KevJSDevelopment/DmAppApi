using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlChannelRepo : IChannelRepo
    {
        private readonly DMAppContext _context;

        public SqlChannelRepo(DMAppContext context)
        {
            _context = context;
        }

        public DiscordGuildChannel CreateChannel(DiscordGuildChannel channel)
        {
            if (channel == null)
            {
                throw new ArgumentNullException(nameof(channel));
            }

            _context.DiscordGuildChannels.Add(channel);
            _context.SaveChanges();

            return channel;
        }

        public void DeleteChannel(long channelId)
        {
            DiscordGuildChannel channel = _context.DiscordGuildChannels.FirstOrDefault(c => c.ChannelId == channelId);

            if (channel == null)
            {
                throw new ArgumentNullException(nameof(channel));
            }

            _context.DiscordGuildChannels.Remove(channel);
        }

        public DiscordGuildChannel GetChannelById(long ChannelId)
        {
            return _context.DiscordGuildChannels.FirstOrDefault(c => c.ChannelId == ChannelId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}