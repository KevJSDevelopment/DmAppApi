using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class DBContextEntityRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterTokens",
                columns: table => new
                {
                    TokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTokens", x => x.TokenId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.CharacterClassId);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.CharacterRaceId);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellLevel = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    TraitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.TraitId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                    table.ForeignKey(
                        name: "FK_Features_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId");
                });

            migrationBuilder.CreateTable(
                name: "GuildClass",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildClass", x => new { x.GuildId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_GuildClass_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildClass_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildItem",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildItem", x => new { x.GuildId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_GuildItem_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildOrganization",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildOrganization", x => new { x.GuildId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_GuildOrganization_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TokenId = table.Column<int>(type: "int", nullable: true),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Acrobatics = table.Column<int>(type: "int", nullable: false),
                    IsAcrobaticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    AnimalHandling = table.Column<int>(type: "int", nullable: false),
                    IsAnimalHandlingProficient = table.Column<bool>(type: "bit", nullable: false),
                    Arcana = table.Column<int>(type: "int", nullable: false),
                    IsArcanaProficient = table.Column<bool>(type: "bit", nullable: false),
                    Athletics = table.Column<int>(type: "int", nullable: false),
                    IsAthleticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    Deception = table.Column<int>(type: "int", nullable: false),
                    IsDeceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    History = table.Column<int>(type: "int", nullable: false),
                    IsHistoryProficient = table.Column<bool>(type: "bit", nullable: false),
                    Insight = table.Column<int>(type: "int", nullable: false),
                    IsInsightProficient = table.Column<bool>(type: "bit", nullable: false),
                    Intimidation = table.Column<int>(type: "int", nullable: false),
                    IsIntimidationProficient = table.Column<bool>(type: "bit", nullable: false),
                    Investigation = table.Column<int>(type: "int", nullable: false),
                    IsInvestigationProficient = table.Column<bool>(type: "bit", nullable: false),
                    Medicine = table.Column<int>(type: "int", nullable: false),
                    IsMedicineProficient = table.Column<bool>(type: "bit", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    IsNatureProficient = table.Column<bool>(type: "bit", nullable: false),
                    Perception = table.Column<int>(type: "int", nullable: false),
                    IsPerceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    IsPerformanceProficient = table.Column<bool>(type: "bit", nullable: false),
                    Persuasion = table.Column<int>(type: "int", nullable: false),
                    IsPersuasionProficient = table.Column<bool>(type: "bit", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    IsReligionProficient = table.Column<bool>(type: "bit", nullable: false),
                    SleightOfHand = table.Column<int>(type: "int", nullable: false),
                    IsSleightOfHandProficient = table.Column<bool>(type: "bit", nullable: false),
                    Stealth = table.Column<int>(type: "int", nullable: false),
                    IsStealthProficient = table.Column<bool>(type: "bit", nullable: false),
                    Survival = table.Column<int>(type: "int", nullable: false),
                    IsSurvivalProficient = table.Column<bool>(type: "bit", nullable: false),
                    StrengthSavingThrow = table.Column<int>(type: "int", nullable: false),
                    DexteritySavingThrow = table.Column<int>(type: "int", nullable: false),
                    ConstitutionSavingThrow = table.Column<int>(type: "int", nullable: false),
                    IntelligenceSavingThrow = table.Column<int>(type: "int", nullable: false),
                    WisdomSavingThrow = table.Column<int>(type: "int", nullable: false),
                    CharismaSavingThrow = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    CurrentHitPoints = table.Column<int>(type: "int", nullable: false),
                    MaxHitPoints = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPoints = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    ProficiencyBonus = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterTokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "CharacterTokens",
                        principalColumn: "TokenId");
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildRace",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildRace", x => new { x.GuildId, x.RaceId });
                    table.ForeignKey(
                        name: "FK_GuildRace_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildRace_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildSpell",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildSpell", x => new { x.GuildId, x.SpellId });
                    table.ForeignKey(
                        name: "FK_GuildSpell_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildTrait",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    TraitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildTrait", x => new { x.GuildId, x.TraitId });
                    table.ForeignKey(
                        name: "FK_GuildTrait_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildTrait_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RacialTraits",
                columns: table => new
                {
                    TraitId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacialTraits", x => new { x.TraitId, x.RaceId });
                    table.ForeignKey(
                        name: "FK_RacialTraits_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacialTraits_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildFeature",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildFeature", x => new { x.GuildId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_GuildFeature_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildFeature_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAlly",
                columns: table => new
                {
                    AllyId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAlly", x => new { x.AllyId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterAlly_Characters_AllyId",
                        column: x => x.AllyId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAlly_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId");
                });

            migrationBuilder.CreateTable(
                name: "CharacterEnemy",
                columns: table => new
                {
                    EnemyId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEnemy", x => new { x.EnemyId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterEnemy_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEnemy_Characters_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId");
                });

            migrationBuilder.CreateTable(
                name: "CharacterFeature",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFeature", x => new { x.FeatureId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterFeature_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFeature_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterGuild",
                columns: table => new
                {
                    GuildId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    JoinedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGuild", x => new { x.GuildId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterGuild_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterGuild_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItem", x => new { x.CharacterId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CharacterItem_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterOrganization",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterOrganization", x => new { x.OrganizationId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterOrganization_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpell",
                columns: table => new
                {
                    SpellId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpell", x => new { x.SpellId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterSpell_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTrait",
                columns: table => new
                {
                    TraitId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTrait", x => new { x.TraitId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_CharacterTrait_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTrait_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAlly_CharacterId",
                table: "CharacterAlly",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEnemy_CharacterId",
                table: "CharacterEnemy",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFeature_CharacterId",
                table: "CharacterFeature",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGuild_CharacterId",
                table: "CharacterGuild",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemId",
                table: "CharacterItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterOrganization_CharacterId",
                table: "CharacterOrganization",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TokenId",
                table: "Characters",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpell_CharacterId",
                table: "CharacterSpell",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTrait_CharacterId",
                table: "CharacterTrait",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ClassId",
                table: "Features",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildClass_ClassId",
                table: "GuildClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildFeature_FeatureId",
                table: "GuildFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildItem_ItemId",
                table: "GuildItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildOrganization_OrganizationId",
                table: "GuildOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildRace_RaceId",
                table: "GuildRace",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildSpell_SpellId",
                table: "GuildSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildTrait_TraitId",
                table: "GuildTrait",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_RacialTraits_RaceId",
                table: "RacialTraits",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterAlly");

            migrationBuilder.DropTable(
                name: "CharacterEnemy");

            migrationBuilder.DropTable(
                name: "CharacterFeature");

            migrationBuilder.DropTable(
                name: "CharacterGuild");

            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterOrganization");

            migrationBuilder.DropTable(
                name: "CharacterSpell");

            migrationBuilder.DropTable(
                name: "CharacterTrait");

            migrationBuilder.DropTable(
                name: "GuildClass");

            migrationBuilder.DropTable(
                name: "GuildFeature");

            migrationBuilder.DropTable(
                name: "GuildItem");

            migrationBuilder.DropTable(
                name: "GuildOrganization");

            migrationBuilder.DropTable(
                name: "GuildRace");

            migrationBuilder.DropTable(
                name: "GuildSpell");

            migrationBuilder.DropTable(
                name: "GuildTrait");

            migrationBuilder.DropTable(
                name: "RacialTraits");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "DiscordGuilds");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "CharacterTokens");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
