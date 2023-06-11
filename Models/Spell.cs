using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Spell
    {
        [Key]
        public int SpellId { get; set; }

        [Required]
        public string Name { get; set; }

        public int SpellLevel { get; set; }

        public string Description { get; set; }

        // Other spell properties

        public IList<Character> Characters { get; set; } = new List<Character>();
    }
}
