﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Hosting;

namespace DMApp.Models
{
    public class CharacterRace
    {
        public CharacterRace()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            Traits = new List<Trait>();

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IList<Character> Characters { get; set; }
        public IList<Trait> Traits { get; set; }
        

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

