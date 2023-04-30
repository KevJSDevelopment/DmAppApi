﻿using System.ComponentModel.DataAnnotations;

namespace DMApp.Dtos
{
    public class CharacterReadDto
    {
        public string? Name { get; set; }

        public string? Class { get; set; }

        public string? Race { get; set; }

        public int Age { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? Eyes { get; set; }

        public string? Skin { get; set; }

        public string? Hair { get; set; }

        public string? Background { get; set; }
    }
}
