using DMApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DMApp.Data
{
    public class DMAppContext : DbContext
    {
        public DMAppContext(DbContextOptions<DMAppContext> opt) : base(opt)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterToken> CharacterTokens { get; set; }
        public DbSet<DiscordGuild> DiscordGuilds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
               .HasMany(c => c.Guilds)
               .WithMany(g => g.Characters)
               .UsingEntity(j => j.ToTable("CharacterGuild"));

            modelBuilder.Entity<Character>()
               .HasOne(c => c.Token)
               .WithMany(g => g.Characters);
        }
    }
}
