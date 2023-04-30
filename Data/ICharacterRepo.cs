using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ICharacterRepo
    {
        bool SaveChanges();
        User GetUser(int id);
        Character GetCharacterById(int id);
        void CreateCharacter(Character character);
        void UpdateCharacter(Character character);
        void DeleteCharacter(Character character);
    }
}