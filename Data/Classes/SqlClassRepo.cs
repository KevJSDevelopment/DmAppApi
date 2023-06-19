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
    public class SqlClassRepo : IClassRepo
    {
        private readonly DMAppContext _context;

        public SqlClassRepo(DMAppContext context)
        {
            _context = context;
        }

        public CharacterClass CreateClass(CharacterClass characterClass)
        {
            if (characterClass == null)
            {
                throw new ArgumentNullException(nameof(characterClass));
            }

            _context.Classes.Add(characterClass);
            _context.SaveChanges();

            return characterClass;
        }

        public void DeleteClass(int @classId)
        {
            CharacterClass @class = _context.Classes.FirstOrDefault(c => c.CharacterClassId == @classId);

            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            _context.Classes.Remove(@class);
        }

        public CharacterClass GetClassById(long @classId)
        {
            return _context.Classes.FirstOrDefault(c => c.CharacterClassId == @classId);
        }


        public IList<CharacterClass> GetClassesByGuildId(long guildId)
        {
            return _context.Classes.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}