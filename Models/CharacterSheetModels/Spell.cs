using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Spell
    {

        public Spell()
        {
            Name = string.Empty;
            SpellLevel = 0;
            Description = string.Empty;
            Characters = new List<Character>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int SpellId { get; set; }
        public string? Name { get; set; }
        public int? SpellLevel { get; set; }
        public string? Description { get; set; }
        public string? ActionType { get; }

        public string? MagicType { get; set; }
        public string? CastingTime { get; set; }
        public int? Range { get; set; }
        public string? Components { get; set; }
        public string? MaterialComponents { get; set; }

        public string? Duration { get; set; }
        public string? AreaOfEffect { get; set; }
        public string? SavingThrow { get; set; }

        public string? DamageType { get; set; }

        public int? DamageDiceCount { get; set; }
        public int? DamageDiceValue { get; set; }

        public int? SpellAttackBonus { get; set; }

        public bool? IsRitual { get; set; }
        public bool? IsConcentration { get; set; }

        public string? ComponentsDescription { get; set; }
        public string? HigherLevelDescription { get; set; }

        // Other spell properties
        public IList<Character> Characters { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
