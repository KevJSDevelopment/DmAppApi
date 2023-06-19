﻿using System.ComponentModel.DataAnnotations;

namespace DMApp.Dtos
{
    public class CharacterCreateDto
    {
        public string? Name { get; set; }

        public string? Class { get; set; }

        public string? Race { get; set; }

        public string? Description { get; set; }
    }
}