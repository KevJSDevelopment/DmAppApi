using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
	public class AbilityScore
	{
        [Key]
        public int AbilityScoreId { get; set; }
        [Required]
        public int CharacterId { get; set; }
        [Required]
        public Character Character { get; set; }


        [Required]
        public int Strength { get; set; } = 0;
        [Required]
        public int Dexterity { get; set; } = 0;
        [Required]
        public int Constitution { get; set; } = 0;
        [Required]
        public int Intelligence { get; set; } = 0;
        [Required]
        public int Wisdom { get; set; } = 0;
        [Required]
        public int Charisma { get; set; } = 0;
    }
}

