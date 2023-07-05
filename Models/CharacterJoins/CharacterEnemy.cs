using System;
namespace DMApp.Models
{
	public class CharacterEnemy
	{
		public int? EnemyId { get; set; }
		public Character Enemy { get; set; }

		public int? CharacterId { get; set; }
		public Character Character { get; set; }
	}
}

