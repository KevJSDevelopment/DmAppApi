using System.Collections.Generic;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IDiscordGuildRepo
    {
        bool SaveChanges();
        IList<Character> GetCharactersByGuildId(long guildId);
        IList<CharacterRace> GetCharacterRacesByGuildId(long guildId);
        IList<CharacterClass> GetCharacterClassesByGuildId(long guildId);
        IList<Feature> GetFeaturesByGuildId(long guildId);
        IList<Trait> GetTraitsByGuildId(long guildId);
        IList<Organization> GetOrganizationsByGuildId(long guildId);
        IList<Item> GetItemsByGuildId(long guildId);
        IList<Spell> GetSpellsByGuildId(long guildId);
        DiscordGuild CreateGuild(long guildId);
        DiscordGuild GetGuildByGuildId(long guildId);
        void DeleteGuild(long guildId);
    }
}