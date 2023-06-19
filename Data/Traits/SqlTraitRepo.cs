using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlTraitRepo : ITraitRepo
    {
        private readonly DMAppContext _context;

        public SqlTraitRepo(DMAppContext context)
        {
            _context = context;
        }

        public Trait CreateTrait(Trait trait)
        {
            if (trait == null)
            {
                throw new ArgumentNullException(nameof(trait));
            }

            _context.Traits.Add(trait);
            _context.SaveChanges();

            return trait;
        }

        public void DeleteTrait(int TraitId)
        {
            Trait Trait = _context.Traits.FirstOrDefault(c => c.TraitId == TraitId);

            if (Trait == null)
            {
                throw new ArgumentNullException(nameof(Trait));
            }

            _context.Traits.Remove(Trait);
        }

        public Trait GetTraitById(long TraitId)
        {
            return _context.Traits.FirstOrDefault(c => c.TraitId == TraitId);
        }


        public IList<Trait> GetTraitsByGuildId(long guildId)
        {
            return _context.Traits.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}