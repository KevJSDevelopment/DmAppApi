using System;
namespace DMApp.Models
{
	public class CharacterClassCharacter
	{
        public int? CharacterId { get; set; }
        public Character Character { get; set; }

        public int? CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
    }
}

