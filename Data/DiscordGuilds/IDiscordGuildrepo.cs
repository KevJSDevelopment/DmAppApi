using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IDiscordGuildRepo
    {
        bool SaveChanges();
        IList<Character> GetCharactersByGuildId(long guildId);
        DiscordGuild CreateGuild(long guildId);
        void DeleteGuild(long guildId);
    }
}