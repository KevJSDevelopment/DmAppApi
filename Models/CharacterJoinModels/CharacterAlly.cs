using System;
namespace DMApp.Models
{
    public class CharacterAlly
    {
        public int? CharacterId { get; set; }
        public Character Character { get; set; }

        public int? AllyId { get; set; }
        public Character Ally { get; set; }
    }
}

