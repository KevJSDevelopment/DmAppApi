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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
            .HasOne(c => c.Token)
            .WithMany(t => t.Characters)
            .HasForeignKey(c => c.TokenId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
