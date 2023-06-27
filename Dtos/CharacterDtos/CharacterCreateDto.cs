using System;
namespace DMApp.Dtos
{
	public class CharacterCreateDto
	{
        public int? CharacterId { get; set; }
        public string? Name { get; set; }

        //Background Info
        public string? Alignment { get; set; }
        public string? Age { get; set; }
        public string? Sex { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Hair { get; set; }
        public string? Background { get; set; }
    }
}

