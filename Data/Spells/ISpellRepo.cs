using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ISpellRepo
    {
        bool SaveChanges();
        Spell CreateSpell(Spell spell);
        Spell GetSpellById(int spellId);
        void DeleteSpell(int spellId);
    }
}