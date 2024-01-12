using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPublic = table.Column<bool>(type: "bit", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: true),
                    Range = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavingThrow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDiceCount = table.Column<int>(type: "int", nullable: true),
                    DamageDiceValue = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagicType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CastingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<int>(type: "int", nullable: true),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialComponents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaOfEffect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavingThrow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageDiceCount = table.Column<int>(type: "int", nullable: true),
                    DamageDiceValue = table.Column<int>(type: "int", nullable: true),
                    SpellAttackBonus = table.Column<int>(type: "int", nullable: true),
                    IsRitual = table.Column<bool>(type: "bit", nullable: true),
                    IsConcentration = table.Column<bool>(type: "bit", nullable: true),
                    ComponentsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HigherLevelDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoiceBlob = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampaignSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionNumber = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    ScheduledStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampaignSessions_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    Immunities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resistances = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulnerabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthModifier = table.Column<int>(type: "int", nullable: false),
                    DexterityModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionModifier = table.Column<int>(type: "int", nullable: false),
                    IntelligenceModifier = table.Column<int>(type: "int", nullable: false),
                    WisdomModifier = table.Column<int>(type: "int", nullable: false),
                    CharismaModifier = table.Column<int>(type: "int", nullable: false),
                    IsAcrobaticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsAnimalHandlingProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsArcanaProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsAthleticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsDeceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsHistoryProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsInsightProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsIntimidationProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsInvestigationProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsMedicineProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsNatureProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPerceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPerformanceProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPersuasionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsReligionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsSleightOfHandProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsStealthProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsSurvivalProficient = table.Column<bool>(type: "bit", nullable: false),
                    StrengthSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    DexteritySavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    IntelligenceSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    WisdomSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    CharismaSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    ArmorClassModifier = table.Column<int>(type: "int", nullable: false),
                    HitPointsModifier = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPointsModifier = table.Column<int>(type: "int", nullable: false),
                    SpeedModifier = table.Column<int>(type: "int", nullable: false),
                    ProficiencyBonusModifier = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    Immunities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resistances = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulnerabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrengthModifier = table.Column<int>(type: "int", nullable: false),
                    DexterityModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionModifier = table.Column<int>(type: "int", nullable: false),
                    IntelligenceModifier = table.Column<int>(type: "int", nullable: false),
                    WisdomModifier = table.Column<int>(type: "int", nullable: false),
                    CharismaModifier = table.Column<int>(type: "int", nullable: false),
                    IsAcrobaticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsAnimalHandlingProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsArcanaProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsAthleticsProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsDeceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsHistoryProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsInsightProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsIntimidationProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsInvestigationProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsMedicineProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsNatureProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPerceptionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPerformanceProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsPersuasionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsReligionProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsSleightOfHandProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsStealthProficient = table.Column<bool>(type: "bit", nullable: false),
                    IsSurvivalProficient = table.Column<bool>(type: "bit", nullable: false),
                    StrengthSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    DexteritySavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    ConstitutionSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    IntelligenceSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    WisdomSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    CharismaSavingThrowModifier = table.Column<int>(type: "int", nullable: false),
                    ArmorClassModifier = table.Column<int>(type: "int", nullable: false),
                    HitPointsModifier = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPointsModifier = table.Column<int>(type: "int", nullable: false),
                    SpeedModifier = table.Column<int>(type: "int", nullable: false),
                    ProficiencyBonusModifier = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Traits_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CampaignUser",
                columns: table => new
                {
                    CampaignsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignUser", x => new { x.CampaignsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CampaignUser_Campaigns_CampaignsId",
                        column: x => x.CampaignsId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignUser_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPlayerCharacter = table.Column<bool>(type: "bit", nullable: true),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    TokenId = table.Column<int>(type: "int", nullable: true),
                    VoiceId = table.Column<int>(type: "int", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Immunities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resistances = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vulnerabilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_CharacterTokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "CharacterTokens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Voices_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "Voices",
                        principalColumn: "Id");
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterAlly_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClassCharacter",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    CharacterClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClassCharacter", x => new { x.CharacterId, x.CharacterClassId });
                    table.ForeignKey(
                        name: "FK_CharacterClassCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClassCharacter_Classes_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEnemy_Characters_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFeature_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterOrganization_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpell_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTrait_Traits_TraitId",
                        column: x => x.TraitId,
                        principalTable: "Traits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampaignSessions_CampaignId",
                table: "CampaignSessions",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignUser_UsersId",
                table: "CampaignUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAlly_CharacterId",
                table: "CharacterAlly",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClassCharacter_CharacterClassId",
                table: "CharacterClassCharacter",
                column: "CharacterClassId");

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
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TokenId",
                table: "Characters",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

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
                name: "IX_Features_ClassId",
                table: "Features",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Traits_RaceId",
                table: "Traits",
                column: "RaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CampaignSessions");

            migrationBuilder.DropTable(
                name: "CampaignUser");

            migrationBuilder.DropTable(
                name: "CharacterAlly");

            migrationBuilder.DropTable(
                name: "CharacterClassCharacter");

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
                name: "Features");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "CharacterTokens");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Voices");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
