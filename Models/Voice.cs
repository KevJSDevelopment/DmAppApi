using System;
using System.Reflection.Metadata;

namespace DMApp.Models
{
	public class Voice
	{
		public Voice()
		{
			Characters = new List<Character>();
		}

		public int? Id { get; set; }

		public byte[]? VoiceBlob { get; set; }

		public IList<Character> Characters { get; set; }

		public DiscordGuild? Guild { get; set; }
	}
}

