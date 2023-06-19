using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IRaceRepo
    {
        bool SaveChanges();
        IList<CharacterRace> GetCharacterRacesByGuildId(long guildId);
        CharacterRace CreateCharacterRace(CharacterRace characterRace);
        void DeleteCharacterRace(int characterRaceId);
    }
}