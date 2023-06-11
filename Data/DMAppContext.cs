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
        public DbSet<CharacterClass> Races { get; set; }
        public DbSet<CharacterRace> Classes { get; set; }
        public DbSet<CharacterToken> CharacterTokens { get; set; }
        public DbSet<DiscordGuild> DiscordGuilds { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<SkillSet> SkillSets { get; set; }
        public DbSet<SavingThrows> SavingThrows { get; set; }
        public DbSet<BackgroundInfo> BackgroundInfos { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Character>()
        //       .HasMany(c => c.Guilds)
        //       .WithMany(g => g.Characters)
        //       .UsingEntity(j => j.ToTable("CharacterGuild"));

        //    modelBuilder.Entity<Character>()
        //       .HasOne(c => c.Token)
        //       .WithMany(g => g.Characters);

        //    modelBuilder.Entity<DiscordGuild>()
        //        .HasAlternateKey(g => g.GuildId);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Token)
                .WithMany(t => t.Characters)
                .HasForeignKey(c => c.TokenId);

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Guilds)
                .WithMany(g => g.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterGuild",
                    j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j =>
                    {
                        j.Property<DateTime>("JoinedOn").HasDefaultValueSql("GETDATE()");
                        j.HasKey("GuildId", "CharacterId");
                    }
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Allies)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterAlly",
                    j => j.HasOne<Character>().WithMany().HasForeignKey("AllyId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("AllyId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Enemies)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterEnemy",
                    j => j.HasOne<Character>().WithMany().HasForeignKey("EnemyId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("EnemyId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Organizations)
                .WithMany(o => o.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterOrganization",
                    j => j.HasOne<Organization>().WithMany().HasForeignKey("OrganizationId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("OrganizationId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasOne(c => c.AbilityScores)
                .WithOne()
                .HasForeignKey<AbilityScore>(a => a.CharacterId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.SkillsList)
                .WithOne()
                .HasForeignKey<SkillSet>(s => s.CharacterId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.SavingThrows)
                .WithOne()
                .HasForeignKey<SavingThrows>(s => s.CharacterId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Background)
                .WithOne()
                .HasForeignKey<BackgroundInfo>(b => b.CharacterId);

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Features)
                .WithMany(f => f.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterFeature",
                    j => j.HasOne<Feature>().WithMany().HasForeignKey("FeatureId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("FeatureId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Traits)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterTrait",
                    j => j.HasOne<Trait>().WithMany().HasForeignKey("TraitId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("TraitId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Items)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterItem",
                    j => j.HasOne<Item>().WithMany().HasForeignKey("ItemId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("ItemId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Spells)
                .WithMany()
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterSpell",
                    j => j.HasOne<Spell>().WithMany().HasForeignKey("SpellId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("SpellId", "CharacterId")
                );

            // Configure the remaining models/entities

            modelBuilder.Entity<CharacterClass>()
            .HasMany(c => c.Features)
            .WithOne(f => f.Class)
            .HasForeignKey(f => f.ClassId);

            modelBuilder.Entity<CharacterRace>()
            .HasMany(r => r.Traits)
            .WithMany(t => t.Races)
            .UsingEntity<Dictionary<string, object>>(
                "RacialTraits",
                j => j.HasOne<Trait>().WithMany().HasForeignKey("TraitId"),
                j => j.HasOne<CharacterRace>().WithMany().HasForeignKey("RaceId"),
                j => j.HasKey("TraitId", "RaceId")
            );


            modelBuilder.Entity<CharacterClass>().ToTable("Classes");
            modelBuilder.Entity<CharacterRace>().ToTable("Races");

            // Configure other models/entities

            base.OnModelCreating(modelBuilder);
        }

    }
}
