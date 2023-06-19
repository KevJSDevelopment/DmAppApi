﻿// <auto-generated />
using System;
using DMApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DMApp.Migrations
{
    [DbContext(typeof(DMAppContext))]
    [Migration("20230611185726_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterAlly", b =>
                {
                    b.Property<int>("AllyId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("AllyId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterAlly");
                });

            modelBuilder.Entity("CharacterEnemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("EnemyId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterEnemy");
                });

            modelBuilder.Entity("CharacterFeature", b =>
                {
                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("FeatureId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterFeature");
                });

            modelBuilder.Entity("CharacterGuild", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoinedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("GuildId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterGuild");
                });

            modelBuilder.Entity("CharacterItem", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("CharacterItem");
                });

            modelBuilder.Entity("CharacterOrganization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("OrganizationId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterOrganization");
                });

            modelBuilder.Entity("CharacterSpell", b =>
                {
                    b.Property<int>("SpellId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("SpellId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterSpell");
                });

            modelBuilder.Entity("CharacterTrait", b =>
                {
                    b.Property<int>("TraitId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("TraitId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterTrait");
                });

            modelBuilder.Entity("DMApp.Models.AbilityScore", b =>
                {
                    b.Property<int>("AbilityScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AbilityScoreId"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("AbilityScoreId");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("AbilityScores");
                });

            modelBuilder.Entity("DMApp.Models.BackgroundInfo", b =>
                {
                    b.Property<int>("BackgroundInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BackgroundInfoId"));

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Eyes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BackgroundInfoId");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("BackgroundInfos");
                });

            modelBuilder.Entity("DMApp.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<int>("AbilityScoreId")
                        .HasColumnType("int");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("BackgroundInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int?>("SavingThrowsId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SkillSetId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("TemporaryHitPoints")
                        .HasColumnType("int");

                    b.Property<int?>("TokenId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.HasIndex("TokenId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DMApp.Models.CharacterClass", b =>
                {
                    b.Property<int>("CharacterClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterClassId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterClassId");

                    b.ToTable("Classes", (string)null);
                });

            modelBuilder.Entity("DMApp.Models.CharacterRace", b =>
                {
                    b.Property<int>("CharacterRaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterRaceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterRaceId");

                    b.ToTable("Races", (string)null);
                });

            modelBuilder.Entity("DMApp.Models.CharacterToken", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TokenId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("TokenId");

                    b.ToTable("CharacterTokens");
                });

            modelBuilder.Entity("DMApp.Models.DiscordGuild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long>("GuildId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DiscordGuilds");
                });

            modelBuilder.Entity("DMApp.Models.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureId"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureId");

                    b.HasIndex("ClassId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("DMApp.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Cost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DMApp.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrganizationId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("DMApp.Models.SavingThrows", b =>
                {
                    b.Property<int>("SavingThrowsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SavingThrowsId"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("SavingThrowsId");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("DMApp.Models.SkillSet", b =>
                {
                    b.Property<int>("SkillSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillSetId"));

                    b.Property<int>("Acrobatics")
                        .HasColumnType("int");

                    b.Property<int>("AnimalHandling")
                        .HasColumnType("int");

                    b.Property<int>("Arcana")
                        .HasColumnType("int");

                    b.Property<int>("Athletics")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Deception")
                        .HasColumnType("int");

                    b.Property<int>("History")
                        .HasColumnType("int");

                    b.Property<int>("Insight")
                        .HasColumnType("int");

                    b.Property<int>("Intimidation")
                        .HasColumnType("int");

                    b.Property<int>("Investigation")
                        .HasColumnType("int");

                    b.Property<bool>("IsAcrobaticsProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAnimalHandlingProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsArcanaProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAthleticsProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeceptionProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHistoryProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInsightProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsIntimidationProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInvestigationProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMedicineProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNatureProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPerceptionProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPerformanceProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPersuasionProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReligionProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSleightOfHandProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStealthProficient")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSurvivalProficient")
                        .HasColumnType("bit");

                    b.Property<int>("Medicine")
                        .HasColumnType("int");

                    b.Property<int>("Nature")
                        .HasColumnType("int");

                    b.Property<int>("Perception")
                        .HasColumnType("int");

                    b.Property<int>("Performance")
                        .HasColumnType("int");

                    b.Property<int>("Persuasion")
                        .HasColumnType("int");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<int>("SleightOfHand")
                        .HasColumnType("int");

                    b.Property<int>("Stealth")
                        .HasColumnType("int");

                    b.Property<int>("Survival")
                        .HasColumnType("int");

                    b.HasKey("SkillSetId");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("SkillSets");
                });

            modelBuilder.Entity("DMApp.Models.Spell", b =>
                {
                    b.Property<int>("SpellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpellId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpellLevel")
                        .HasColumnType("int");

                    b.HasKey("SpellId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("DMApp.Models.Trait", b =>
                {
                    b.Property<int>("TraitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraitId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TraitId");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("RacialTraits", b =>
                {
                    b.Property<int>("TraitId")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("TraitId", "RaceId");

                    b.HasIndex("RaceId");

                    b.ToTable("RacialTraits");
                });

            modelBuilder.Entity("CharacterAlly", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("AllyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterEnemy", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterFeature", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Feature", null)
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterGuild", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterItem", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterOrganization", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Organization", null)
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSpell", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Spell", null)
                        .WithMany()
                        .HasForeignKey("SpellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterTrait", b =>
                {
                    b.HasOne("DMApp.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DMApp.Models.AbilityScore", b =>
                {
                    b.HasOne("DMApp.Models.Character", "Character")
                        .WithOne("AbilityScores")
                        .HasForeignKey("DMApp.Models.AbilityScore", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DMApp.Models.BackgroundInfo", b =>
                {
                    b.HasOne("DMApp.Models.Character", "Character")
                        .WithOne("Background")
                        .HasForeignKey("DMApp.Models.BackgroundInfo", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DMApp.Models.Character", b =>
                {
                    b.HasOne("DMApp.Models.CharacterClass", "Class")
                        .WithMany("Characters")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.CharacterRace", "Race")
                        .WithMany("Characters")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.CharacterToken", "Token")
                        .WithMany("Characters")
                        .HasForeignKey("TokenId");

                    b.Navigation("Class");

                    b.Navigation("Race");

                    b.Navigation("Token");
                });

            modelBuilder.Entity("DMApp.Models.Feature", b =>
                {
                    b.HasOne("DMApp.Models.CharacterClass", "Class")
                        .WithMany("Features")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DMApp.Models.SavingThrows", b =>
                {
                    b.HasOne("DMApp.Models.Character", "Character")
                        .WithOne("SavingThrows")
                        .HasForeignKey("DMApp.Models.SavingThrows", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DMApp.Models.SkillSet", b =>
                {
                    b.HasOne("DMApp.Models.Character", "Character")
                        .WithOne("SkillsList")
                        .HasForeignKey("DMApp.Models.SkillSet", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("RacialTraits", b =>
                {
                    b.HasOne("DMApp.Models.CharacterRace", null)
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DMApp.Models.Character", b =>
                {
                    b.Navigation("AbilityScores")
                        .IsRequired();

                    b.Navigation("Background")
                        .IsRequired();

                    b.Navigation("SavingThrows")
                        .IsRequired();

                    b.Navigation("SkillsList")
                        .IsRequired();
                });

            modelBuilder.Entity("DMApp.Models.CharacterClass", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Features");
                });

            modelBuilder.Entity("DMApp.Models.CharacterRace", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("DMApp.Models.CharacterToken", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}