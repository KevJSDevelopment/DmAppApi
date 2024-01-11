using System;
using System.Reflection.Metadata;

namespace DMApp.Models
{
	public class Voice
	{
		public Voice()
		{
			Characters = new List<Character>();

            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

		public int Id { get; set; }

		public byte[]? VoiceBlob { get; set; }

		public IList<Character> Characters { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

