using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Character
    {
        [Key] public int CharacterId { get; set; }
        [Required] public string Name { get; set; }

        [Required] public string Class { get; set; }

        [Required] public string Race { get; set; }
        [Required] public int UserId { get; set; }

        public User User { get; set; }

        public int Age { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public string Eyes { get; set; }

        public string Skin { get; set; }

        public string Hair { get; set; }

        public string Background { get; set; }

        public int TokenId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
