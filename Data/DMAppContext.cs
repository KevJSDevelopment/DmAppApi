using System.Diagnostics;
using System.Reflection.Metadata;
using DMApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;

namespace DMApp.Data
{
    public class DMAppContext : DbContext
    {
        public DMAppContext(DbContextOptions<DMAppContext> opt) : base(opt)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignSession> CampaignSessions { get; set; }
        public DbSet<Voice> Voices { get; set; }
        public DbSet<CharacterRace> Races { get; set; }
        public DbSet<CharacterClass> Classes { get; set; }
        public DbSet<CharacterToken> CharacterTokens { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Spell> Spells { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCharacter(modelBuilder);
            ConfigureCharacterClass(modelBuilder);
            ConfigureCharacterRace(modelBuilder);
            ConfigureFeature(modelBuilder);
            ConfigureTrait(modelBuilder);
            ConfigureItem(modelBuilder);
            ConfigureSpell(modelBuilder);
            ConfigureCampaign(modelBuilder);

            // Seed Data
            // CharacterSeedData.SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureCharacter(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<CharacterClassCharacter>()
                .HasKey(ccc => new { ccc.CharacterId, ccc.CharacterClassId });

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Classes)
                .WithMany(cc => cc.Characters)
                .UsingEntity<CharacterClassCharacter>(
                    j => j.HasOne(cc => cc.CharacterClass)
                        .WithMany()
                        .HasForeignKey(cc => cc.CharacterClassId),
                    j => j
                        .HasOne(c => c.Character)
                        .WithMany()
                        .HasForeignKey(c => c.CharacterId)
                );

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
                        .HasForeignKey(ce => ce.AllyId)
                        .OnDelete(DeleteBehavior.Restrict), // Set the delete behavior to Restrict
                    j => j
                        .HasOne(ce => ce.Character)
                        .WithMany()
                        .HasForeignKey(ce => ce.CharacterId)
                        .OnDelete(DeleteBehavior.Cascade) // Set the delete behavior to Cascade
                );

            modelBuilder.Entity<Character>()
                .HasMany(c => c.Enemies)
                .WithMany()
                .UsingEntity<CharacterEnemy>(
                    j => j
                        .HasOne(ce => ce.Enemy)
                        .WithMany()
                        .HasForeignKey(ce => ce.EnemyId)
                        .OnDelete(DeleteBehavior.Restrict), // Set the delete behavior to Restrict
                    j => j
                        .HasOne(ce => ce.Character)
                        .WithMany()
                        .HasForeignKey(ce => ce.CharacterId)
                        .OnDelete(DeleteBehavior.Cascade) // Set the delete behavior to Cascade
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
                .HasMany(c => c.Features)
                .WithOne(f => f.Class)
                .HasForeignKey(f => f.ClassId);

            // Configure other relationships and constraints for the CharacterClass entity
        }

        private void ConfigureCharacterRace(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterRace>()
                .HasMany(r => r.Traits)
                .WithOne(t => t.Race)
                .HasForeignKey(t => t.RaceId);

            // Configure other relationships and constraints for the CharacterRace entity
        }

        private void ConfigureFeature(ModelBuilder modelBuilder)
        {
           
        }

        private void ConfigureTrait(ModelBuilder modelBuilder)
        {
            
        }

        private void ConfigureItem(ModelBuilder modelBuilder)
        {

        }

        private void ConfigureSpell(ModelBuilder modelBuilder)
        {

        }

        private void ConfigureCampaign(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.CampaignSessions)
                .WithOne(s => s.Campaign);

            modelBuilder.Entity<Campaign>()
                .HasMany(c => c.Characters)
                .WithOne(ch => ch.Campaign);

            modelBuilder.Entity<Campaign>()
            .HasMany(c => c.Users)
            .WithMany(u => u.Campaigns);

        }

        //public override int SaveChanges()
        //{
        //    ValidateGuildChannelConfiguration();

        //    return base.SaveChanges();
        //}

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    ValidateGuildChannelConfiguration();

        //    return await base.SaveChangesAsync(cancellationToken);
        //}
    }
}
