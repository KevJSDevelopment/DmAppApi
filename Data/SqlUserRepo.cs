using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;

namespace DMApp.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly DMAppContext _context;

        public SqlUserRepo(DMAppContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.Users.Remove(user);
        }

        public ICollection<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(p => p.Username == username);
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.UserId == id);
        }
        public bool SaveChanges()
        {
            // save changes to database, return true if successful or false if fails
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(User user)
        {
            //Nothing
        }

        public ICollection<Character> GetCharactersByUserId(int userId){
            var characters = _context.Characters.Where(c => c.UserId == userId).ToList();
            
            return characters;
        }
    }
}