using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Dtos;
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

        public DiscordGuild UpdateGuild(DiscordGuild guild)
        {
            _context.DiscordGuilds.Update(guild);
            _context.SaveChanges(); // Save changes to the database
            return guild; // Return the updated guild
        }


        public DiscordGuild CreateGuild(long guildId)
        {
            
            DiscordGuild guild = new DiscordGuild
            {
                GuildId = guildId
            };

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

        public IList<Campaign> GetCampaignsByGuildId(long guildId)
        {
            return _context.Campaigns
            .Where(c => c.GuildId == guildId)
            .ToList();
        }

        public IList<Character> GetCharactersByGuildId(long guildId)
        {
            return _context.Characters
            .Where(c => c.Guilds.Any(g => g.GuildId == guildId))
            .ToList();
        }

        public IList<CharacterRace> GetCharacterRacesByGuildId(long guildId)
        {   
            return _context.Races
            .Where(r => r.Guilds.Any(g => g.GuildId == guildId))
            .ToList();
        }

        public IList<CharacterClass> GetCharacterClassesByGuildId(long guildId)
        {
            return _context.Classes
            .Where(c => c.Guilds.Any(g => g.GuildId == guildId))
            .ToList();
        }

        public IList<Feature> GetFeaturesByGuildId(long guildId)
        {
            return _context.Features.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public IList<Trait> GetTraitsByGuildId(long guildId)
        {
            return _context.Traits.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public IList<Organization> GetOrganizationsByGuildId(long guildId)
        {
            return _context.Organizations.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public IList<Item> GetItemsByGuildId(long guildId)
        {
            return _context.Items.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public IList<Spell> GetSpellsByGuildId(long guildId)
        {
            return _context.Spells.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}