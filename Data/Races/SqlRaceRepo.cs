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

        public CharacterRace CreateCharacterRace(CharacterRace characterRace,long guildId)
        {
            
            if (characterRace == null)
            {
                throw new ArgumentNullException(nameof(characterRace));
            }

            // Check if a character race with the same name already exists for the guild
            bool raceExists = _context.Races
                .Any(r => r.Name == characterRace.Name && r.Guilds.Any(gr => gr.GuildId == guildId));

            if (raceExists)
            {
                // Return a validation response indicating that the race already exists
                // You can choose an appropriate way to handle this, such as throwing an exception or returning an error message.
                throw new InvalidOperationException("A character race with the same name already exists for the guild.");
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

        public CharacterRace GetCharacterRaceByName(string name,long guildId)
        {
            long defaultId = 0;

            try
            {
                long.TryParse(Environment.GetEnvironmentVariable("DefaultGuildId"), out defaultId);
            }
            catch (Exception ex)
            {

            }

            return _context.Races.FirstOrDefault(r => r.Name == name && r.Guilds.Any(g => g.GuildId == guildId || g.GuildId == defaultId));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}