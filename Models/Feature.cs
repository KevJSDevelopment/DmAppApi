using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public CharacterClass Class { get; set; }

        public IList<Character> Characters { get; set; } = new List<Character>();
    }
}
