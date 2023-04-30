using DMApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DMApp.Data
{
    public class DMAppContext : DbContext
    {
        public DMAppContext(DbContextOptions<DMAppContext> opt) : base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasAlternateKey(k => k.Username)
            .HasName("AlternateKey_Username");


            modelBuilder.Entity<Character>()
            .HasOne(c => c.User)
            .WithMany(c => c.Characters)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
