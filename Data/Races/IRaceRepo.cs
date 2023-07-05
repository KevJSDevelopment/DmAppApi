using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IRaceRepo
    {
        bool SaveChanges();
        CharacterRace CreateCharacterRace(CharacterRace characterRace, long guildId);
        CharacterRace GetCharacterRaceById(int id);
        CharacterRace GetCharacterRaceByName(string name, long guildId);
        void DeleteCharacterRace(int characterRaceId);
    }
}