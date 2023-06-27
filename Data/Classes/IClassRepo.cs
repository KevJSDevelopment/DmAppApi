using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IClassRepo
    {
        bool SaveChanges();
        CharacterClass CreateClass(CharacterClass characterClass);
        CharacterClass GetCharacterClassById(int id);
        CharacterClass GetCharacterClassByName(string name);
        void DeleteClass(int classId);
    }
}