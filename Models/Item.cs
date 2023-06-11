using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace DMApp.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Cost { get; set; }

        // Other item properties
        public IList<Character> Characters { get; set; } = new List<Character>();
    }
}

