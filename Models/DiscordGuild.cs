using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class DiscordGuild
    {
        [Key]
        public long GuildId { get; set; }

        [Required]
        public IList<Character> Characters { get; set; } = new List<Character>();

        // Other properties...

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
