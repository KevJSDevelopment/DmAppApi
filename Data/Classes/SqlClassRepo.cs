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

        public CharacterClass CreateCharacterClass(CharacterClass characterClass)
        {
            if (characterClass == null) throw new ArgumentNullException(nameof(characterClass));

            characterClass.Id = 0;
            _context.Classes.Add(characterClass);
            _context.SaveChanges();

            return characterClass;
        }


        public CharacterClass GetCharacterClassById(int id)
        {
            return _context.Classes.FirstOrDefault(c => c.Id == id);
        }

        public CharacterClass GetCharacterClassByName(string name)
        {
            long defaultId = 0;

            try
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out defaultId);
            }
            catch (Exception ex) {
                
            }

            return _context.Classes.FirstOrDefault(c => c.Name == name);
        }

        public void DeleteClass(int @classId)
        {
            CharacterClass @class = _context.Classes.FirstOrDefault(c => c.Id == @classId);

            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            _context.Classes.Remove(@class);
        }

        public CharacterClass GetClassById(int @classId)
        {
            return _context.Classes.FirstOrDefault(c => c.Id == @classId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}