using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();
        ICollection<User> GetAllUsers();
        User GetUserByUsername(string username);
        User GetUserById(int id);
        // Follower GetFollowerById(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        ICollection<Character> GetCharactersByUserId(int userId);
    }
}