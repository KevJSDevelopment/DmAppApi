using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface ITraitRepo
    {
        bool SaveChanges();
        Trait CreateTrait(Trait trait);
        Trait GetTraitById(int TraitId);
        void DeleteTrait(int TraitId);
    }
}