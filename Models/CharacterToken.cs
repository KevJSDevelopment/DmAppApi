﻿using System;
using System.ComponentModel.DataAnnotations;
using Discord;
using Microsoft.Extensions.Hosting;

namespace DMApp.Models
{
    public class CharacterToken
    {
        public CharacterToken()
        {
            IsPublic = false;
            Characters = new List<Character>();
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        [Key]
        public int TokenId { get; set; }
        public bool IsPublic { get; set; }
        public Byte[]? Image { get; set; }

        public IList<Character> Characters { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
 
}

