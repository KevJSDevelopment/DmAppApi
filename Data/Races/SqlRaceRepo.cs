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

            // Check if a character race with the same name already exists for the guild
            bool raceExists = _context.Races
                .Any(r => r.Name == characterRace.Name);

            if (raceExists)
            {
                // Return a validation response indicating that the race already exists
                // You can choose an appropriate way to handle this, such as throwing an exception or returning an error message.
                throw new InvalidOperationException("A character race with the same name already exists.");
            }

            characterRace.Id = 0;

            _context.Races.Add(characterRace);
            _context.SaveChanges();

            return characterRace;
        }


        public CharacterRace GetCharacterRaceById(int id)
        {
            return _context.Races.FirstOrDefault(r => r.Id == id);
        }

        public void DeleteCharacterRace(int characterRaceId)
        {
            CharacterRace CharacterRace = _context.Races.FirstOrDefault(c => c.Id == characterRaceId);

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