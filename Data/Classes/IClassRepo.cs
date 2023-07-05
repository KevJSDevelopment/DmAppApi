using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IClassRepo
    {
        bool SaveChanges();
        CharacterClass CreateCharacterClass(CharacterClass characterClass, long guildId);
        CharacterClass GetCharacterClassById(int id);
        CharacterClass GetCharacterClassByName(string name, long guildId);
        void DeleteClass(int classId);
    }
}