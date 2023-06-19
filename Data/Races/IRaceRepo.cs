using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IRaceRepo
    {
        bool SaveChanges();
        IList<CharacterRace> GetCharacterRacesByGuildId(long guildId);
        CharacterRace CreateCharacterRace(int characterRaceId);
        void DeleteCharacterRace(int characterRaceId);
    }
}