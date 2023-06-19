﻿// <auto-generated />
using System;
using DMApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DMApp.Migrations
{
    [DbContext(typeof(DMAppContext))]
    partial class DMAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DMApp.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<int>("Acrobatics")
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alignment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AnimalHandling")
                        .HasColumnType("int");

                    b.Property<int>("Arcana")
                        .HasColumnType("int");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("Athletics")
                        .HasColumnType("int");

                    b.Property<string>("Background")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("CharismaSavingThrow")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("ConstitutionSavingThrow")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Deception")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("DexteritySavingThrow")
                        .HasColumnType("int");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("int");

                    b.Property<string>("Eyes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("History")
                        .HasColumnType("int");

                    b.Property<int>("Insight")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("IntelligenceSavingThrow")
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

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("Medicine")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nature")
                        .HasColumnType("int");

                    b.Property<int>("Perception")
                        .HasColumnType("int");

                    b.Property<int>("Performance")
                        .HasColumnType("int");

                    b.Property<int>("Persuasion")
                        .HasColumnType("int");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SleightOfHand")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Stealth")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("StrengthSavingThrow")
                        .HasColumnType("int");

                    b.Property<int>("Survival")
                        .HasColumnType("int");

                    b.Property<int>("TemporaryHitPoints")
                        .HasColumnType("int");

                    b.Property<int?>("TokenId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.Property<int>("WisdomSavingThrow")
                        .HasColumnType("int");

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

                    b.HasKey("CharacterClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DMApp.Models.CharacterRace", b =>
                {
                    b.Property<int>("CharacterRaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterRaceId"));

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

                    b.HasKey("CharacterRaceId");

                    b.ToTable("Races");
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

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

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

                    b.Property<int?>("Cost")
                        .IsRequired()
                        .HasColumnType("int");

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

            modelBuilder.Entity("DMApp.Models.Spell", b =>
                {
                    b.Property<int>("SpellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpellId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpellLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("SpellId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("DMApp.Models.Trait", b =>
                {
                    b.Property<int>("TraitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraitId"));

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

                    b.HasKey("TraitId");

                    b.ToTable("Traits");
                });

            modelBuilder.Entity("GuildClass", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "ClassId");

                    b.HasIndex("ClassId");

                    b.ToTable("GuildClass");
                });

            modelBuilder.Entity("GuildFeature", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("GuildFeature");
                });

            modelBuilder.Entity("GuildItem", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("GuildItem");
                });

            modelBuilder.Entity("GuildOrganization", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "OrganizationId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("GuildOrganization");
                });

            modelBuilder.Entity("GuildRace", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "RaceId");

                    b.HasIndex("RaceId");

                    b.ToTable("GuildRace");
                });

            modelBuilder.Entity("GuildSpell", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("SpellId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "SpellId");

                    b.HasIndex("SpellId");

                    b.ToTable("GuildSpell");
                });

            modelBuilder.Entity("GuildTrait", b =>
                {
                    b.Property<int>("GuildId")
                        .HasColumnType("int");

                    b.Property<int>("TraitId")
                        .HasColumnType("int");

                    b.HasKey("GuildId", "TraitId");

                    b.HasIndex("TraitId");

                    b.ToTable("GuildTrait");
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
                        .HasForeignKey("ClassId");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("GuildClass", b =>
                {
                    b.HasOne("DMApp.Models.CharacterClass", null)
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildFeature", b =>
                {
                    b.HasOne("DMApp.Models.Feature", null)
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildItem", b =>
                {
                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildOrganization", b =>
                {
                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Organization", null)
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildRace", b =>
                {
                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.CharacterRace", null)
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildSpell", b =>
                {
                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Spell", null)
                        .WithMany()
                        .HasForeignKey("SpellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuildTrait", b =>
                {
                    b.HasOne("DMApp.Models.DiscordGuild", null)
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMApp.Models.Trait", null)
                        .WithMany()
                        .HasForeignKey("TraitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
