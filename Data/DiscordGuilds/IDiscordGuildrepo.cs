using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IDiscordGuildRepo
    {
        bool SaveChanges();
        IList<Character> GetCharactersByGuildId(int guildId);
        void CreateGuild(int guildId);
        void DeleteGuild(int guildId);
    }
}