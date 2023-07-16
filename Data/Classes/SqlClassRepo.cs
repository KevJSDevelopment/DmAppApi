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

        public CharacterClass CreateCharacterClass(CharacterClass characterClass,long guildId)
        {
            

            if (characterClass == null) throw new ArgumentNullException(nameof(characterClass));


            characterClass.CharacterClassId = 0;

            // Check if a character class with the same name already exists for the guild
            bool classExists = _context.Classes.Any(c => c.Name != null && c.Name == characterClass.Name && c.Guilds.Any(g => g.GuildId == guildId));

            // Return a validation response indicating that the class already exists
            // You can choose an appropriate way to handle this, such as throwing an exception or returning an error message.
            if (classExists) throw new InvalidOperationException("A character class with the same name already exists for the guild.");

            _context.Classes.Add(characterClass);
            _context.SaveChanges();

            return characterClass;
        }


        public CharacterClass GetCharacterClassById(int id)
        {
            return _context.Classes.FirstOrDefault(c => c.CharacterClassId == id);
        }

        public CharacterClass GetCharacterClassByName(string name, long guildId)
        {
            long defaultId = 0;

            try
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out defaultId);
            }
            catch (Exception ex) {
                
            }

            return _context.Classes.FirstOrDefault(c => c.Name == name && c.Guilds.Any(g => g.GuildId == guildId || g.GuildId == defaultId));
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

        public CharacterClass GetClassById(int @classId)
        {
            return _context.Classes.FirstOrDefault(c => c.CharacterClassId == @classId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}