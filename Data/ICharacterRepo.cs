using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ICharacterRepo
    {
        bool SaveChanges();
        Character GetCharacterById(int id);
        Character CreateCharacter(Character character);
        void UpdateCharacter(Character character);
        void DeleteCharacter(Character character);
    }
}