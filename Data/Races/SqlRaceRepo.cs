using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlCharacterRaceRepo : IRaceRepo
    {
        private readonly DMAppContext _context;

        public SqlCharacterRaceRepo(DMAppContext context)
        {
            _context = context;
        }

        public CharacterRace CreateCharacterRace(int characterRaceId)
        {
            CharacterRace CharacterRace = new CharacterRace();
            CharacterRace.CharacterRaceId = characterRaceId;
            if (CharacterRace == null)
            {
                throw new ArgumentNullException(nameof(CharacterRace));
            }

            _context.Races.Add(CharacterRace);
            _context.SaveChanges();

            return CharacterRace;
        }

        public void DeleteCharacterRace(int characterRaceId)
        {
            CharacterRace CharacterRace = _context.Races.FirstOrDefault(c => c.CharacterRaceId == characterRaceId);

            if (CharacterRace == null)
            {
                throw new ArgumentNullException(nameof(CharacterRace));
            }

            _context.Races.Remove(CharacterRace);
        }

        public CharacterRace GetCharacterRaceById(long CharacterRaceId)
        {
            return _context.Races.FirstOrDefault(c => c.CharacterRaceId == CharacterRaceId);
        }


        public IList<CharacterRace> GetCharacterRacesByGuildId(long guildId)
        {
            return _context.Races.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}