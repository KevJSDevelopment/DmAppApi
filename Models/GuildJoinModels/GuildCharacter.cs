using System;
namespace DMApp.Models
{
	public class GuildCharacter
	{
		public long? GuildId { get; set; }
		public DiscordGuild? Guild { get; set; }

		public int? CharacterId { get; set; }
		public Character? Character { get; set; }

		public DateTime JoinedOn { get; set; }
	}
}

