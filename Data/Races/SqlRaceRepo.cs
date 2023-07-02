using DMApp.Models;

namespace DMApp.Data
{
    public class SqlCharacterRaceRepo : IRaceRepo
    {
        private readonly DMAppContext _context;

        public SqlCharacterRaceRepo(DMAppContext context)
        {
            _context = context;
        }

        public CharacterRace CreateCharacterRace(CharacterRace characterRace)
        {
            if (characterRace == null)
            {
                throw new ArgumentNullException(nameof(characterRace));
            }

            characterRace.CharacterRaceId = 0;

            _context.Races.Add(characterRace);
            _context.SaveChanges();

            return characterRace;
        }

        public CharacterRace GetCharacterRaceById(int id)
        {
            return _context.Races.FirstOrDefault(r => r.CharacterRaceId == id);
        }

        public void DeleteCharacterRace(int characterRaceId)
        {
            CharacterRace CharacterRace = _context.Races.FirstOrDefault(c => c.CharacterRaceId == characterRaceId);

            if (CharacterRace == null)
            {
                throw new ArgumentNullException(nameof(CharacterRace));
            }

            _context.Races.Remove(CharacterRace);
        }

        public CharacterRace GetCharacterRaceByName(string name)
        {
            return _context.Races.FirstOrDefault(r => r.Name == name);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}