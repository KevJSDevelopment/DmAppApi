using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IClassRepo
    {
        bool SaveChanges();
        IList<CharacterClass> GetClassesByGuildId(long guildId);
        CharacterClass CreateClass(int classId);
        void DeleteClass(int classId);
    }
}