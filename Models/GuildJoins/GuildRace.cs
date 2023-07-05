using System;
namespace DMApp.Models
{
    public class GuildRace
    {
        public long GuildId { get; set; }
        public DiscordGuild Guild { get; set; }

        public int CharacterRaceId { get; set; }
        public CharacterRace CharacterRace { get; set; }
    }
}

