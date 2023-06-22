using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ITraitRepo
    {
        bool SaveChanges();
        Trait CreateTrait(Trait trait);
        void DeleteTrait(int TraitId);
    }
}