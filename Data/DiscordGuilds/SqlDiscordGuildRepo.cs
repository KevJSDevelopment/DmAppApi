using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlDiscordGuildRepo : IDiscordGuildRepo
    {
        private readonly DMAppContext _context;

        public SqlDiscordGuildRepo(DMAppContext context)
        {
            _context = context;
        }

        public DiscordGuild GetGuildByGuildId(long guildId)
        {
            return _context.DiscordGuilds.FirstOrDefault(g => g.GuildId == guildId);
        }

        public DiscordGuild CreateGuild(long guildId)
        {
            DiscordGuild guild = new DiscordGuild();
            guild.GuildId = guildId;
            if (guild == null)
            {
                throw new ArgumentNullException(nameof(guild));
            }

            _context.DiscordGuilds.Add(guild);
            _context.SaveChanges();

            return guild;
        }

        public void DeleteGuild(long guildId)
        {
            DiscordGuild guild = _context.DiscordGuilds.FirstOrDefault(g => g.GuildId == guildId);

            if (guild == null)
            {
                throw new ArgumentNullException(nameof(guild));
            }

            _context.DiscordGuilds.Remove(guild);
        }

        public IList<Character> GetCharactersByGuildId(long guildId)
        {
            return _context.Characters
            .Where(c => c.Guilds.Any(g => g.GuildId == guildId))
            .ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}