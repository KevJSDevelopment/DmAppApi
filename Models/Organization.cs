﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Organization
    {
        public Organization()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Guilds = new List<DiscordGuild>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        [Key]
        public int OrganizationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<DiscordGuild> Guilds { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

