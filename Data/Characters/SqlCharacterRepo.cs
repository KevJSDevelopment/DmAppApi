using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Dtos;
using DMApp.Models;

namespace DMApp.Data
{
    public class SqlCharacterRepo : ICharacterRepo
    {
        private readonly DMAppContext _context;

        public SqlCharacterRepo(DMAppContext context)
        {
            _context = context;
        }

        public Character CreateCharacter(Character character, long guildId)
        {
            DiscordGuild guild = _context.DiscordGuilds.FirstOrDefault(g => g.GuildId == guildId);

            if (character == null || guild == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            character.Guilds.Add(guild);

            _context.Characters.Add(character);
            _context.SaveChanges();

            return character;
        }


        public void DeleteCharacter(Character character)
        {
            if(character == null)
            {
                throw new ArgumentNullException(nameof(character));
            }

            _context.Characters.Remove(character);
        }

        public Character GetCharacterById(int id)
        {
            return _context.Characters.FirstOrDefault(p => p.CharacterId == id);
        }

        public void UpdateCharacter(Character character)
        {
            //Nothing
        }

        public bool SaveChanges()
        {
            // save changes to database, return true if successful or false if fails
            return (_context.SaveChanges() >= 0);
        }
    }
}