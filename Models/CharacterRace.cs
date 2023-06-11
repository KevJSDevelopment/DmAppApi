using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class CharacterRace
    {
        [Key]
        public int CharacterRaceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public IList<Character> Characters { get; set; } = new List<Character>();

        public IList<Trait> Traits { get; set; } = new List<Trait>();
    }
}

