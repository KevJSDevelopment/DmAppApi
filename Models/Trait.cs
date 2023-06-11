using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace DMApp.Models
{
    public class Trait
    {
        [Key]
        public int TraitId { get; set; }

        [Required]
        public int CharacterId { get; set; }
        [Required]
        public Character Character { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IList<CharacterRace> Races { get; set; } = new List<CharacterRace>();
    }
}

