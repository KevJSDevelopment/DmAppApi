using System.Diagnostics;
using System.Reflection.Metadata;
using DMApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DMApp.Data
{
    public class DMAppContext : DbContext
    {
        public DMAppContext(DbContextOptions<DMAppContext> opt) : base(opt)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Voice> Voices { get; set; }
        public DbSet<CharacterRace> Races { get; set; }
        public DbSet<CharacterClass> Classes { get; set; }
        public DbSet<CharacterToken> CharacterTokens { get; set; }
        public DbSet<DiscordGuild> DiscordGuilds { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feature>()
                .HasKey(f => f.FeatureId);
            modelBuilder.Entity<Trait>()
                .HasKey(t => t.TraitId);
            modelBuilder.Entity<Item>()
                .HasKey(i => i.ItemId);
            modelBuilder.Entity<Spell>()
                .HasKey(s => s.SpellId);
            modelBuilder.Entity<CharacterToken>()
                .HasKey(ct => ct.TokenId);
            modelBuilder.Entity<Organization>()
                .HasKey(o => o.OrganizationId);
            modelBuilder.Entity<Campaign>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Session>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<Voice>()
                .HasKey(v => v.Id);

            ConfigureCharacter(modelBuilder);
            ConfigureCharacterClass(modelBuilder);
            ConfigureCharacterRace(modelBuilder);
            ConfigureDiscordGuild(modelBuilder);
            // Configure other entities...

            CharacterSeedData.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureCharacter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasKey(c => c.CharacterId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Token)
                .WithMany(t => t.Characters)
                .HasForeignKey(c => c.TokenId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.CharacterVoice)
                .WithMany(v => v.Characters)
                .HasForeignKey(c => c.VoiceId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Race)
                .WithMany(cr => cr.Characters)
                .HasForeignKey(c => c.RaceId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.Class)
                .WithMany(cc => cc.Characters)
                .HasForeignKey(c => c.ClassId);

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
                .HasMany(c => c.Features)
                .WithMany(f => f.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterFeature",
                    j => j.HasOne<Feature>().WithMany().HasForeignKey("FeatureId").OnDelete(DeleteBehavior.Restrict),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("FeatureId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Traits)
                .WithMany(t => t.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterTrait",
                    j => j.HasOne<Trait>().WithMany().HasForeignKey("TraitId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("TraitId", "CharacterId")
                );

            modelBuilder.Entity<Character>()
            .HasMany(c => c.Items)
            .WithMany(i => i.Characters)
            .UsingEntity<Dictionary<string, object>>(
                "CharacterItem",
                j => j.HasOne<Item>().WithMany().HasForeignKey("ItemId"),
                j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                j => j.HasKey("CharacterId", "ItemId")
            );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Spells)
                .WithMany(s => s.Characters)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterSpell",
                    j => j.HasOne<Spell>().WithMany().HasForeignKey("SpellId"),
                    j => j.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    j => j.HasKey("SpellId", "CharacterId")
                );
            // Configure other relationships and constraints for the Character entity
        }

        private void ConfigureCharacterClass(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterClass>()
              .HasKey(c => c.CharacterClassId);

            modelBuilder.Entity<CharacterClass>()
                .HasMany(c => c.Features)
                .WithOne(f => f.Class)
                .HasForeignKey(f => f.ClassId);

            // Configure other relationships and constraints for the CharacterClass entity
        }

        private void ConfigureCharacterRace(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterRace>()
                .HasKey(c => c.CharacterRaceId);

            modelBuilder.Entity<CharacterRace>()
                .HasMany(r => r.Traits)
                .WithOne(t => t.Race)
                .HasForeignKey(t => t.RaceId);

            // Configure other relationships and constraints for the CharacterRace entity
        }

        private void ConfigureDiscordGuild(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiscordGuild>()
            .HasKey(g => g.GuildId);

            modelBuilder.Entity<DiscordGuild>()
            .Property(g => g.GuildId)
            .ValueGeneratedNever();

            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.CharacterClasses)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildClass",
                j => j.HasOne<CharacterClass>().WithMany().HasForeignKey("ClassId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "ClassId")
            );

            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.CharacterRaces)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildRace",
                j => j.HasOne<CharacterRace>().WithMany().HasForeignKey("RaceId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "RaceId")
            );

            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Features)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildFeature",
                j => j.HasOne<Feature>().WithMany().HasForeignKey("FeatureId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "FeatureId")
            );


            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Traits)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildTrait",
                j => j.HasOne<Trait>().WithMany().HasForeignKey("TraitId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "TraitId")
            );


            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Organizations)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildOrganization",
                j => j.HasOne<Organization>().WithMany().HasForeignKey("OrganizationId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "OrganizationId")
            );

            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Items)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildItem",
                j => j.HasOne<Item>().WithMany().HasForeignKey("ItemId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "ItemId")
            );


            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Spells)
            .WithMany(c => c.Guilds)
            .UsingEntity<Dictionary<string, object>>(
                "GuildSpell",
                j => j.HasOne<Spell>().WithMany().HasForeignKey("SpellId"),
                j => j.HasOne<DiscordGuild>().WithMany().HasForeignKey("GuildId"),
                j => j.HasKey("GuildId", "SpellId")
            );

            modelBuilder.Entity<DiscordGuild>()
            .HasMany(g => g.Campaigns)
            .WithOne(c => c.Guild);
        }

        private void ConfigureSession(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>()
                .HasOne(s => s.campaign);

        }
    }
}
