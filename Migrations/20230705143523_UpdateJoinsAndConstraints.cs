using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateJoinsAndConstraints : Migration
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
                    IsPublic = table.Column<bool>(type: "bit", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuilds", x => x.GuildId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuildId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId");
                });

            migrationBuilder.CreateTable(
                name: "GuildClass",
                columns: table => new
                {
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildClass", x => new { x.GuildId, x.CharacterClassId });
                    table.ForeignKey(
                        name: "FK_GuildClass_Classes_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildClass_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoiceBlob = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    GuildId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voices_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId");
                });

            migrationBuilder.CreateTable(
                name: "GuildItem",
                columns: table => new
                {
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildItem", x => new { x.GuildId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_GuildItem_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
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
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildOrganization", x => new { x.GuildId, x.OrganizationId });
                    table.ForeignKey(
                        name: "FK_GuildOrganization_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuildRace",
                columns: table => new
                {
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    CharacterRaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildRace", x => new { x.GuildId, x.CharacterRaceId });
                    table.ForeignKey(
                        name: "FK_GuildRace_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildRace_Races_CharacterRaceId",
                        column: x => x.CharacterRaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    TraitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.TraitId);
                    table.ForeignKey(
                        name: "FK_Traits_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId");
                });

            migrationBuilder.CreateTable(
                name: "GuildSpell",
                columns: table => new
                {
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildSpell", x => new { x.GuildId, x.SpellId });
                    table.ForeignKey(
                        name: "FK_GuildSpell_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildFeature",
                columns: table => new
                {
                    FeaturesFeatureId = table.Column<int>(type: "int", nullable: false),
                    GuildsGuildId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildFeature", x => new { x.FeaturesFeatureId, x.GuildsGuildId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildFeature_DiscordGuilds_GuildsGuildId",
                        column: x => x.GuildsGuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildFeature_Features_FeaturesFeatureId",
                        column: x => x.FeaturesFeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionNumber = table.Column<int>(type: "int", nullable: true),
                    campaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Campaigns_campaignId",
                        column: x => x.campaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    TokenId = table.Column<int>(type: "int", nullable: true),
                    VoiceId = table.Column<int>(type: "int", nullable: true),
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
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_CharacterTokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "CharacterTokens",
                        principalColumn: "TokenId");
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId");
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId");
                    table.ForeignKey(
                        name: "FK_Characters_Voices_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "Voices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildTrait",
                columns: table => new
                {
                    GuildsGuildId = table.Column<long>(type: "bigint", nullable: false),
                    TraitsTraitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildTrait", x => new { x.GuildsGuildId, x.TraitsTraitId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildTrait_DiscordGuilds_GuildsGuildId",
                        column: x => x.GuildsGuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildTrait_Traits_TraitsTraitId",
                        column: x => x.TraitsTraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAlly",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    AllyId = table.Column<int>(type: "int", nullable: false)
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
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFeature", x => new { x.CharacterId, x.FeatureId });
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
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterOrganization", x => new { x.CharacterId, x.OrganizationId });
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
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    SpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpell", x => new { x.CharacterId, x.SpellId });
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
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    TraitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTrait", x => new { x.CharacterId, x.TraitId });
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

            migrationBuilder.CreateTable(
                name: "GuildCharacter",
                columns: table => new
                {
                    GuildId = table.Column<long>(type: "bigint", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    JoinedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildCharacter", x => new { x.GuildId, x.CharacterId });
                    table.ForeignKey(
                        name: "FK_GuildCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuildCharacter_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "CharacterClassId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9360), "A fierce warrior of primitive background who taps into their rage to unleash devastating attacks.", "Barbarian", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9360) },
                    { 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), "A spellcaster who uses their performances to weave magic and inspire allies or hinder foes.", "Bard", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) },
                    { 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), "A holy warrior who channels divine power to heal allies, smite enemies, and protect the faith.", "Cleric", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) },
                    { 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), "A spellcaster who draws power from nature and can transform into animals, commanding natural forces.", "Druid", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) },
                    { 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), "A versatile warrior skilled in combat maneuvers and capable of taking on a variety of roles.", "Fighter", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) },
                    { 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), "A disciplined warrior who has honed their body into a deadly weapon and gained mastery over ki.", "Monk", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) },
                    { 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), "A holy knight dedicated to upholding justice and righteousness, channeling divine power in combat.", "Paladin", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) },
                    { 8, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), "A skilled hunter and tracker who excels at ranged combat and navigating the wilderness.", "Ranger", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) },
                    { 9, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), "A stealthy scoundrel who specializes in deception, agility, and exploiting their foes' weaknesses.", "Rogue", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) },
                    { 10, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), "A spellcaster with innate magical abilities, able to shape and cast spells through force of personality.", "Sorcerer", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) },
                    { 11, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390), "A spellcaster who makes a pact with a powerful entity, gaining magical abilities in exchange for service.", "Warlock", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390) },
                    { 12, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390), "A scholarly magic-user who studies arcane knowledge and casts spells through careful study and preparation.", "Wizard", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390) }
                });

            migrationBuilder.InsertData(
                table: "DiscordGuilds",
                columns: new[] { "GuildId", "CreatedOn", "UpdatedOn" },
                values: new object[] { 1077311704985239684L, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Cost", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 75, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9870), "It aint good, but it aint bad either", "Chain mail", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9870) },
                    { 2, 20, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9880), "A short bow", "Short bow", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9880) }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), "A secret organization dedicated to preserving knowledge, maintaining balance, and fighting evil in all its forms.", "Harper's Guild", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) },
                    { 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), "A militant order that seeks to protect the innocent, enforce justice, and eradicate evil from the world.", "Order of the Gauntlet", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) },
                    { 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), "A society of druids and other nature-focused individuals who strive to protect the natural world and maintain the balance of nature.", "Emerald Enclave", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) },
                    { 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), "A political alliance of powerful city-states and influential leaders who work together to maintain stability and ensure the safety of their respective regions.", "Lords' Alliance", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) },
                    { 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), "A secretive and powerful mercenary organization that operates in the shadows, pursuing wealth, power, and influence through any means necessary.", "Zhentarim", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) },
                    { 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720), "A scattered network of spies and informants who work to promote good, gather information, and thwart the plans of evil organizations.", "Harpers", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720) },
                    { 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720), "A fanatical cult that seeks to raise and control dragons, believing that they are the key to ultimate power and world domination.", "Cult of the Dragon", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720) }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "CharacterRaceId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9610), "A humanoid creature with draconic ancestry, possessing dragon-like features and abilities.", "Dragonborn", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) },
                    { 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), "A stout and tough humanoid known for their resilience, craftsmanship, and strong sense of tradition.", "Dwarf", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) },
                    { 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), "A graceful and long-lived humanoid race with a deep connection to magic and the natural world.", "Elf", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) },
                    { 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), "A small and inventive humanoid known for their curiosity, ingenuity, and love of tinkering.", "Gnome", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) },
                    { 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), "A mixed heritage humanoid with both human and elven ancestry, combining the best traits of both races.", "Half-Elf", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) },
                    { 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), "A powerful and intimidating humanoid born from the union of orc and human parents, known for their strength and resilience.", "Half-Orc", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) },
                    { 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), "A small and nimble humanoid known for their luck, agility, and ability to avoid danger.", "Halfling", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) },
                    { 8, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), "A versatile and adaptable humanoid race, known for their ambition, diversity, and capacity for greatness.", "Human", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) },
                    { 9, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), "A humanoid with infernal bloodline, often bearing demonic traits and possessing a connection to the Fiend.", "Tiefling", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "SpellId", "CreatedOn", "Description", "Name", "SpellLevel", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900), "", "Spell 1", 0, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900) },
                    { 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900), "", "Spell 2", 0, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900) }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "CreatedOn", "Description", "Name", "RaceId", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9830), "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table.", "Draconic Ancestry", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) },
                    { 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), "You can use your action to exhale destructive energy.", "Breath Weapon", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) },
                    { 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), "Accustomed to life underground, you have superior vision in dark and dim conditions.", "Darkvision", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) },
                    { 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), "You have advantage on saving throws against poison and resistance against poison damage.", "Dwarven Resilience", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) },
                    { 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), "You have advantage on saving throws against being charmed, and magic can't put you to sleep.", "Fey Ancestry", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) },
                    { 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", "Gnome Cunning", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) },
                    { 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "Your Charisma score increases by 2, and two other ability scores of your choice increase by 1.", "Ability Score Increase", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) },
                    { 8, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead.", "Relentless Endurance", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) },
                    { 9, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.", "Lucky", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) },
                    { 10, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "You have advantage on saving throws against being frightened.", "Brave", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) },
                    { 11, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), "You have resistance to fire damage.", "Hellish Resistance", null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Acrobatics", "Age", "Alignment", "AnimalHandling", "Arcana", "ArmorClass", "Athletics", "Background", "CampaignId", "Charisma", "CharismaSavingThrow", "ClassId", "Constitution", "ConstitutionSavingThrow", "CreatedOn", "CurrentHitPoints", "Deception", "Dexterity", "DexteritySavingThrow", "ExperiencePoints", "Eyes", "Hair", "Height", "History", "Insight", "Intelligence", "IntelligenceSavingThrow", "Intimidation", "Investigation", "IsAcrobaticsProficient", "IsAnimalHandlingProficient", "IsArcanaProficient", "IsAthleticsProficient", "IsDeceptionProficient", "IsHistoryProficient", "IsInsightProficient", "IsIntimidationProficient", "IsInvestigationProficient", "IsMedicineProficient", "IsNatureProficient", "IsPerceptionProficient", "IsPerformanceProficient", "IsPersuasionProficient", "IsReligionProficient", "IsSleightOfHandProficient", "IsStealthProficient", "IsSurvivalProficient", "Level", "MaxHitPoints", "Medicine", "Name", "Nature", "Perception", "Performance", "Persuasion", "ProficiencyBonus", "RaceId", "Religion", "Sex", "Skin", "SleightOfHand", "Speed", "Stealth", "Strength", "StrengthSavingThrow", "Survival", "TemporaryHitPoints", "TokenId", "UpdatedOn", "VoiceId", "Weight", "Wisdom", "WisdomSavingThrow" },
                values: new object[,]
                {
                    { 1, 0, "", "", 0, 0, 10, 0, "", null, 10, 0, 1, 10, 0, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9960), 10, 0, 10, 0, 0, "", "", "", 0, 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Grondar", 0, 0, 0, 0, 0, 1, 0, "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9960), null, "", 10, 0 },
                    { 2, 0, "", "", 0, 0, 10, 0, "", null, 10, 0, 2, 10, 0, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9970), 10, 0, 10, 0, 0, "", "", "", 0, 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Zander", 0, 0, 0, 0, 0, 2, 0, "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9970), null, "", 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ClassId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9740), "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action.", "Rage", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9740) },
                    { 2, 1, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), "While you are not wearing any armor, your AC equals 10 + your Dexterity modifier + your Constitution modifier.", "Unarmored Defense", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) },
                    { 3, 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), "You can inspire others through stirring words or music. As a bonus action, you can choose one creature within 60 feet.", "Bardic Inspiration", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) },
                    { 4, 2, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music.", "Spellcasting", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) },
                    { 5, 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), "Choose a divine domain, such as Life or Tempest, that grants you domain spells and other features.", "Divine Domain", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) },
                    { 6, 3, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), "At 2nd level, you gain the ability to channel divine energy directly from your deity.", "Channel Divinity", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) },
                    { 7, 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages.", "Druidic", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) },
                    { 8, 4, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.", "Spellcasting", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) },
                    { 9, 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), "You adopt a particular style of fighting as your specialty. Choose one of the following options.", "Fighting Style", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) },
                    { 10, 5, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), "You have a limited well of stamina that you can draw on to protect yourself from harm.", "Second Wind", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) },
                    { 11, 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), "While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", "Unarmored Defense", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) },
                    { 12, 6, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons.", "Martial Arts", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) },
                    { 13, 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears.", "Divine Sense", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) },
                    { 14, 7, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest.", "Lay on Hands", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) },
                    { 15, 8, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.", "Favored Enemy", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 16, 8, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "You are a master of navigating the natural world and have a deep understanding of the terrain.", "Natural Explorer", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 17, 9, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "Beginning at 1st level, you know how to strike subtly and exploit a foe's distraction.", "Sneak Attack", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 18, 9, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "During your rogue training, you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages.", "Thieves' Cant", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 19, 10, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "Choose a sorcerous origin, which describes the source of your innate magical power.", "Sorcerous Origin", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 20, 10, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic.", "Spellcasting", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) },
                    { 21, 11, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), "At 1st level, you have struck a bargain with an otherworldly being of your choice.", "Otherworldly Patron", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) },
                    { 22, 11, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), "Your arcane research and the magic bestowed on you by your patron have given you facility with spells.", "Pact Magic", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) },
                    { 23, 12, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.", "Spellcasting", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) },
                    { 24, 12, new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), "You have learned to regain some of your magical energy by studying your spellbook.", "Arcane Recovery", new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) }
                });

            migrationBuilder.InsertData(
                table: "CharacterAlly",
                columns: new[] { "AllyId", "CharacterId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterEnemy",
                columns: new[] { "CharacterId", "EnemyId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterFeature",
                columns: new[] { "CharacterId", "FeatureId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CharacterItem",
                columns: new[] { "CharacterId", "ItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterOrganization",
                columns: new[] { "CharacterId", "OrganizationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterSpell",
                columns: new[] { "CharacterId", "SpellId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CharacterTrait",
                columns: new[] { "CharacterId", "TraitId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "GuildCharacter",
                columns: new[] { "CharacterId", "GuildId", "JoinedOn" },
                values: new object[,]
                {
                    { 1, 1077311704985239684L, new DateTime(2023, 7, 5, 14, 35, 22, 943, DateTimeKind.Utc).AddTicks(30) },
                    { 2, 1077311704985239684L, new DateTime(2023, 7, 5, 14, 35, 22, 943, DateTimeKind.Utc).AddTicks(30) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_GuildId",
                table: "Campaigns",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAlly_CharacterId",
                table: "CharacterAlly",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEnemy_CharacterId",
                table: "CharacterEnemy",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFeature_FeatureId",
                table: "CharacterFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemId",
                table: "CharacterItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterOrganization_OrganizationId",
                table: "CharacterOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CampaignId",
                table: "Characters",
                column: "CampaignId");

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
                name: "IX_Characters_VoiceId",
                table: "Characters",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpell_SpellId",
                table: "CharacterSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTrait_TraitId",
                table: "CharacterTrait",
                column: "TraitId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildFeature_GuildsGuildId",
                table: "DiscordGuildFeature",
                column: "GuildsGuildId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildTrait_TraitsTraitId",
                table: "DiscordGuildTrait",
                column: "TraitsTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ClassId",
                table: "Features",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildCharacter_CharacterId",
                table: "GuildCharacter",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildClass_CharacterClassId",
                table: "GuildClass",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildItem_ItemId",
                table: "GuildItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildOrganization_OrganizationId",
                table: "GuildOrganization",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildRace_CharacterRaceId",
                table: "GuildRace",
                column: "CharacterRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildSpell_SpellId",
                table: "GuildSpell",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_campaignId",
                table: "Sessions",
                column: "campaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_RaceId",
                table: "Traits",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_GuildId",
                table: "Voices",
                column: "GuildId");
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
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterOrganization");

            migrationBuilder.DropTable(
                name: "CharacterSpell");

            migrationBuilder.DropTable(
                name: "CharacterTrait");

            migrationBuilder.DropTable(
                name: "DiscordGuildFeature");

            migrationBuilder.DropTable(
                name: "DiscordGuildTrait");

            migrationBuilder.DropTable(
                name: "GuildCharacter");

            migrationBuilder.DropTable(
                name: "GuildClass");

            migrationBuilder.DropTable(
                name: "GuildItem");

            migrationBuilder.DropTable(
                name: "GuildOrganization");

            migrationBuilder.DropTable(
                name: "GuildRace");

            migrationBuilder.DropTable(
                name: "GuildSpell");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "CharacterTokens");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Voices");

            migrationBuilder.DropTable(
                name: "DiscordGuilds");
        }
    }
}
