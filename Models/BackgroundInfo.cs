using System;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
	public class BackgroundInfo
	{
        [Key]
        public int BackgroundInfoId { get; set; }
        [Required]
        public int CharacterId { get; set; }
        [Required]
        public Character Character { get; set; }

        public string? Age { get; set; } = "";
        public string? Sex { get; set; } = "";
        public string? Height { get; set; } = "";
        public string? Weight { get; set; } = "";
        public string? Eyes { get; set; } = "";
        public string? Skin { get; set; } = "";
        public string? Hair { get; set; } = "";
        public string? Background { get; set; } = "";
        public string? Alignment { get; set; } = "";
    }
}

