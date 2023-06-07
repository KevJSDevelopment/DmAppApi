using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class CharacterToken
    {
        [Key]
        public int TokenId { get; set; }

        public bool IsPublic { get; set; }

        public Byte[]? Image { get; set; }

        public IList<Character>? Characters { get; set; }

        // Additional properties related to the token

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
 
}

