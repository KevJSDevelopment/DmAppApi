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

            // Seed Data
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

            // CharacterAlly
            modelBuilder.Entity<CharacterAlly>()
                .HasKey(ce => new { ce.AllyId, ce.CharacterId });

            // CharacterEnemy
            modelBuilder.Entity<CharacterEnemy>()
                .HasKey(ce => new { ce.EnemyId, ce.CharacterId });

            // CharacterOrganization
            modelBuilder.Entity<CharacterOrganization>()
                .HasKey(co => new { co.CharacterId, co.OrganizationId });

            // CharacterFeature
            modelBuilder.Entity<CharacterFeature>()
                .HasKey(cf => new { cf.CharacterId, cf.FeatureId });

            // CharacterTrait
            modelBuilder.Entity<CharacterTrait>()
                .HasKey(ct => new { ct.CharacterId, ct.TraitId });

            // CharacterItem
            modelBuilder.Entity<CharacterItem>()
                .HasKey(ci => new { ci.CharacterId, ci.ItemId });

            // CharacterSpell
            modelBuilder.Entity<CharacterSpell>()
                .HasKey(cs => new { cs.CharacterId, cs.SpellId });

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Allies)
                .WithMany()
                .UsingEntity<CharacterAlly>(
                    j => j
                        .HasOne(ce => ce.Ally)
                        .WithMany()
                        .HasForeignKey(ce => ce.AllyId),
                    j => j
                        .HasOne(ce => ce.Character)
                        .WithMany()
                        .HasForeignKey(ce => ce.CharacterId)
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Enemies)
                .WithMany()
                .UsingEntity<CharacterEnemy>(
                    j => j
                        .HasOne(ce => ce.Enemy)
                        .WithMany()
                        .HasForeignKey(ce => ce.EnemyId),
                    j => j
                        .HasOne(ce => ce.Character)
                        .WithMany()
                        .HasForeignKey(ce => ce.CharacterId)
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Organizations)
                .WithMany(o => o.Characters)
                .UsingEntity<CharacterOrganization>(
                    j => j
                        .HasOne(co => co.Org)
                        .WithMany()
                        .HasForeignKey(co => co.OrganizationId),
                    j => j
                        .HasOne(co => co.Character)
                        .WithMany()
                        .HasForeignKey(co => co.CharacterId)
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Features)
                .WithMany(f => f.Characters)
                .UsingEntity<CharacterFeature>(
                    j => j
                        .HasOne(cf => cf.Feature)
                        .WithMany()
                        .HasForeignKey(cf => cf.FeatureId),
                    j => j
                        .HasOne(cf => cf.Character)
                        .WithMany()
                        .HasForeignKey(cf => cf.CharacterId)
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Traits)
                .WithMany(t => t.Characters)
                .UsingEntity<CharacterTrait>(
                    j => j
                        .HasOne(ct => ct.Trait)
                        .WithMany()
                        .HasForeignKey(ct => ct.TraitId),
                    j => j
                        .HasOne(ct => ct.Character)
                        .WithMany()
                        .HasForeignKey(ct => ct.CharacterId)
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Items)
                .WithMany(i => i.Characters)
                .UsingEntity<CharacterItem>(
                    j => j
                        .HasOne(ci => ci.Item)
                        .WithMany()
                        .HasForeignKey(ci => ci.ItemId),
                    j => j
                        .HasOne(ci => ci.Character)
                        .WithMany()
                        .HasForeignKey(ci => ci.CharacterId)
                );

            modelBuilder.Entity<Character>()
               .HasMany(c => c.Spells)
               .WithMany(i => i.Characters)
               .UsingEntity<CharacterSpell>(
                   j => j
                       .HasOne(ci => ci.Spell)
                       .WithMany()
                       .HasForeignKey(ci => ci.SpellId),
                   j => j
                       .HasOne(ci => ci.Character)
                       .WithMany()
                       .HasForeignKey(ci => ci.CharacterId)
               );

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
             .HasMany(g => g.Characters)
             .WithMany(c => c.Guilds)
             .UsingEntity<GuildCharacter>(
                j => j
                     .HasOne(gc => gc.Character)
                     .WithMany()
                     .HasForeignKey(gc => gc.CharacterId),
                j => j
                     .HasOne(gc => gc.Guild)
                     .WithMany()
                     .HasForeignKey(gc => gc.GuildId),
                j =>
                    {
                        j.Property<DateTime>("JoinedOn").HasDefaultValueSql("GETDATE()");
                        j.HasKey("GuildId", "CharacterId");
                    }
                );

            // GuildCharacter
            modelBuilder.Entity<GuildCharacter>()
                .HasKey(gc => new { gc.GuildId, gc.CharacterId });

            // GuildClass
            modelBuilder.Entity<GuildClass>()
                .HasKey(gcl => new { gcl.GuildId, gcl.CharacterClassId });

            // GuildRace
            modelBuilder.Entity<GuildRace>()
                .HasKey(gr => new { gr.GuildId, gr.CharacterRaceId });

            // GuildOrganization
            modelBuilder.Entity<GuildOrganization>()
                .HasKey(go => new { go.GuildId, go.OrganizationId });

            // GuildItem
            modelBuilder.Entity<GuildItem>()
                .HasKey(gi => new { gi.GuildId, gi.ItemId });

            // GuildSpell
            modelBuilder.Entity<GuildSpell>()
                .HasKey(gs => new { gs.GuildId, gs.SpellId });

            modelBuilder.Entity<DiscordGuild>()
                .HasMany(g => g.CharacterClasses)
                .WithMany(cc => cc.Guilds)
                .UsingEntity<GuildClass>(
                    j => j
                        .HasOne(gc => gc.CharacterClass)
                        .WithMany()
                        .HasForeignKey(gc => gc.CharacterClassId),
                    j => j
                        .HasOne(gc => gc.Guild)
                        .WithMany()
                        .HasForeignKey(gc => gc.GuildId),
                    j => j
                        .HasKey("GuildId", "CharacterClassId")
                );

            modelBuilder.Entity<DiscordGuild>()
                .HasMany(g => g.CharacterRaces)
                .WithMany(cr => cr.Guilds)
                .UsingEntity<GuildRace>(
                    j => j
                        .HasOne(gr => gr.CharacterRace)
                        .WithMany()
                        .HasForeignKey(gr => gr.CharacterRaceId),
                    j => j
                        .HasOne(gr => gr.Guild)
                        .WithMany()
                        .HasForeignKey(gr => gr.GuildId),
                    j => j
                        .HasKey("GuildId", "CharacterRaceId")
                );

            modelBuilder.Entity<DiscordGuild>()
                .HasMany(g => g.Organizations)
                .WithMany(o => o.Guilds)
                .UsingEntity<GuildOrganization>(
                    j => j
                        .HasOne(go => go.Org)
                        .WithMany()
                        .HasForeignKey(go => go.OrganizationId),
                    j => j
                        .HasOne(go => go.Guild)
                        .WithMany()
                        .HasForeignKey(go => go.GuildId),
                    j => j
                        .HasKey("GuildId", "OrganizationId")
                );

            modelBuilder.Entity<DiscordGuild>()
                .HasMany(g => g.Items)
                .WithMany(i => i.Guilds)
                .UsingEntity<GuildItem>(
                    j => j
                        .HasOne(gi => gi.Item)
                        .WithMany()
                        .HasForeignKey(gi => gi.ItemId),
                    j => j
                        .HasOne(gi => gi.Guild)
                        .WithMany()
                        .HasForeignKey(gi => gi.GuildId),
                    j => j
                        .HasKey("GuildId", "ItemId")
                );

            modelBuilder.Entity<DiscordGuild>()
                .HasMany(g => g.Spells)
                .WithMany(s => s.Guilds)
                .UsingEntity<GuildSpell>(
                    j => j
                        .HasOne(gs => gs.Spell)
                        .WithMany()
                        .HasForeignKey(gs => gs.SpellId),
                    j => j
                        .HasOne(gs => gs.Guild)
                        .WithMany()
                        .HasForeignKey(gs => gs.GuildId),
                    j => j
                        .HasKey("GuildId", "SpellId")
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
