using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
	public class CharacterClass
	{
        [Key]
        public int CharacterClassId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public IList<Character> Characters { get; set; } = new List<Character>();

        public IList<Feature> Features { get; set; } = new List<Feature>();
    }
}

