using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;

namespace DMApp.Data
{
    public class SqlCharacterRepo : ICharacterRepo
    {
        private readonly DMAppContext _context;

        public SqlCharacterRepo(DMAppContext context)
        {
            _context = context;
        }

        public User GetUser(int id)
        {
            Character character = _context.Characters.FirstOrDefault(c => c.CharacterId == id);

            return _context.Users.FirstOrDefault(u => character.UserId == u.UserId);
        }

        public void CreateCharacter(Character character)
        {
            if(character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Characters.Add(character);
        }

        public void DeleteCharacter(Character character)
        {
            if(character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Characters.Remove(character);
        }

        public Character GetCharacterById(int id)
        {
            return _context.Characters.FirstOrDefault(p => p.CharacterId == id);
        }

        public void UpdateCharacter(Character character)
        {
            //Nothing
        }

        public bool SaveChanges()
        {
            // save changes to database, return true if successful or false if fails
            return (_context.SaveChanges() >= 0);
        }
    }
}