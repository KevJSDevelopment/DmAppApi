using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IRaceRepo
    {
        bool SaveChanges();
        CharacterRace CreateCharacterRace(CharacterRace characterRace);
        CharacterRace GetCharacterRaceById(int id);
        CharacterRace GetCharacterRaceByName(string name);
        void DeleteCharacterRace(int characterRaceId);
    }
}