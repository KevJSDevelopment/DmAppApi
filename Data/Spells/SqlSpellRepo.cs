using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlSpellRepo : ISpellRepo
    {
        private readonly DMAppContext _context;

        public SqlSpellRepo(DMAppContext context)
        {
            _context = context;
        }

        public Spell CreateSpell(Spell spell)
        {
            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            _context.Spells.Add(spell);
            _context.SaveChanges();

            return spell;
        }

        public void DeleteSpell(int spellId)
        {
            Spell spell = _context.Spells.FirstOrDefault(c => c.SpellId == spellId);

            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            _context.Spells.Remove(spell);
        }

        public Spell GetSpellById(long spellId)
        {
            return _context.Spells.FirstOrDefault(c => c.SpellId == spellId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}