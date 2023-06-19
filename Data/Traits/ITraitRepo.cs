using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ITraitRepo
    {
        bool SaveChanges();
        IList<Trait> GetTraitsByGuildId(long guildId);
        Trait CreateTrait(int TraitId);
        void DeleteTrait(int TraitId);
    }
}