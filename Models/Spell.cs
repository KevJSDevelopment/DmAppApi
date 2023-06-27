﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Spell
    {
        public Spell()
        {
            Name = string.Empty;
            SpellLevel = 0;
            Description = string.Empty;
            Characters = new List<Character>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int SpellId { get; set; }
        public string Name { get; set; }
        public int SpellLevel { get; set; }
        public string Description { get; set; }

        // Other spell properties
        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
