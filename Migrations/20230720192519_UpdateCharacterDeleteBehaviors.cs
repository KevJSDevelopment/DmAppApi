using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacterDeleteBehaviors : Migration
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
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuildId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                    table.ForeignKey(
                        name: "FK_Campaigns_DiscordGuilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "GuildId");
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildChannels",
                columns: table => new
                {
                    ChannelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isCharacterAssetChannel = table.Column<bool>(type: "bit", nullable: false),
                    isDmOnlyChannel = table.Column<bool>(type: "bit", nullable: false),
                    GuildId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildChannels", x => x.ChannelId);
                    table.ForeignKey(
                        name: "FK_DiscordGuildChannels_DiscordGuilds_GuildId",
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
                    VoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoiceBlob = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    GuildId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voices", x => x.VoiceId);
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
                    SessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionNumber = table.Column<int>(type: "int", nullable: true),
                    CampaignId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Sessions_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId");
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
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
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "CampaignId");
                    table.ForeignKey(
                        name: "FK_Characters_CharacterTokens_TokenId",
                        column: x => x.TokenId,
                        principalTable: "CharacterTokens",
                        principalColumn: "TokenId");
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId");
                    table.ForeignKey(
                        name: "FK_Characters_Voices_VoiceId",
                        column: x => x.VoiceId,
                        principalTable: "Voices",
                        principalColumn: "VoiceId");
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterAlly_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
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
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClassCharacter_Classes_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "Classes",
                        principalColumn: "CharacterClassId",
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
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEnemy_Characters_EnemyId",
                        column: x => x.EnemyId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
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
                    { 1, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5710), "A fierce warrior of primitive background who taps into their rage to unleash devastating attacks.", "Barbarian", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5710) },
                    { 2, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720), "A spellcaster who uses their performances to weave magic and inspire allies or hinder foes.", "Bard", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720) },
                    { 3, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720), "A holy warrior who channels divine power to heal allies, smite enemies, and protect the faith.", "Cleric", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720) },
                    { 4, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720), "A spellcaster who draws power from nature and can transform into animals, commanding natural forces.", "Druid", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720) },
                    { 5, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720), "A versatile warrior skilled in combat maneuvers and capable of taking on a variety of roles.", "Fighter", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720) },
                    { 6, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5720), "A disciplined warrior who has honed their body into a deadly weapon and gained mastery over ki.", "Monk", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730) },
                    { 7, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730), "A holy knight dedicated to upholding justice and righteousness, channeling divine power in combat.", "Paladin", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730) },
                    { 8, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730), "A skilled hunter and tracker who excels at ranged combat and navigating the wilderness.", "Ranger", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730) },
                    { 9, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730), "A stealthy scoundrel who specializes in deception, agility, and exploiting their foes' weaknesses.", "Rogue", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730) },
                    { 10, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730), "A spellcaster with innate magical abilities, able to shape and cast spells through force of personality.", "Sorcerer", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5730) },
                    { 11, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5740), "A spellcaster who makes a pact with a powerful entity, gaining magical abilities in exchange for service.", "Warlock", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5740) },
                    { 12, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5740), "A scholarly magic-user who studies arcane knowledge and casts spells through careful study and preparation.", "Wizard", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(5740) }
                });

            migrationBuilder.InsertData(
                table: "DiscordGuilds",
                columns: new[] { "GuildId", "CreatedOn", "UpdatedOn" },
                values: new object[] { 1077311704985239684L, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6140), new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AreaOfEffect", "Cost", "CreatedOn", "DamageDiceCount", "DamageDiceValue", "DamageType", "Description", "Duration", "Name", "Range", "SavingThrow", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, 75, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6530), null, null, null, "It aint good, but it aint bad either", null, "Chain mail", null, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6530) },
                    { 2, null, 20, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6530), null, null, null, "A short bow", null, "Short bow", null, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6530) }
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "OrganizationId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6220), "A secret organization dedicated to preserving knowledge, maintaining balance, and fighting evil in all its forms.", "Harper's Guild", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6220) },
                    { 2, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230), "A militant order that seeks to protect the innocent, enforce justice, and eradicate evil from the world.", "Order of the Gauntlet", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230) },
                    { 3, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230), "A society of druids and other nature-focused individuals who strive to protect the natural world and maintain the balance of nature.", "Emerald Enclave", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230) },
                    { 4, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230), "A political alliance of powerful city-states and influential leaders who work together to maintain stability and ensure the safety of their respective regions.", "Lords' Alliance", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230) },
                    { 5, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230), "A secretive and powerful mercenary organization that operates in the shadows, pursuing wealth, power, and influence through any means necessary.", "Zhentarim", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230) },
                    { 6, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230), "A scattered network of spies and informants who work to promote good, gather information, and thwart the plans of evil organizations.", "Harpers", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6230) },
                    { 7, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6240), "A fanatical cult that seeks to raise and control dragons, believing that they are the key to ultimate power and world domination.", "Cult of the Dragon", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6240) }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "CharacterRaceId", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090), "A humanoid creature with draconic ancestry, possessing dragon-like features and abilities.", "Dragonborn", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090) },
                    { 2, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090), "A stout and tough humanoid known for their resilience, craftsmanship, and strong sense of tradition.", "Dwarf", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090) },
                    { 3, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090), "A graceful and long-lived humanoid race with a deep connection to magic and the natural world.", "Elf", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090) },
                    { 4, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090), "A small and inventive humanoid known for their curiosity, ingenuity, and love of tinkering.", "Gnome", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090) },
                    { 5, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090), "A mixed heritage humanoid with both human and elven ancestry, combining the best traits of both races.", "Half-Elf", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6090) },
                    { 6, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100), "A powerful and intimidating humanoid born from the union of orc and human parents, known for their strength and resilience.", "Half-Orc", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100) },
                    { 7, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100), "A small and nimble humanoid known for their luck, agility, and ability to avoid danger.", "Halfling", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100) },
                    { 8, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100), "A versatile and adaptable humanoid race, known for their ambition, diversity, and capacity for greatness.", "Human", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100) },
                    { 9, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100), "A humanoid with infernal bloodline, often bearing demonic traits and possessing a connection to the Fiend.", "Tiefling", new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6100) }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "SpellId", "AreaOfEffect", "CastingTime", "Components", "ComponentsDescription", "CreatedOn", "DamageDiceCount", "DamageDiceValue", "DamageType", "Description", "Duration", "HigherLevelDescription", "IsConcentration", "IsRitual", "MagicType", "MaterialComponents", "Name", "Range", "SavingThrow", "SpellAttackBonus", "SpellLevel", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, null, null, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6550), null, null, null, "", null, null, null, null, null, null, "Spell 1", null, null, null, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6550) },
                    { 2, null, null, null, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6550), null, null, null, "", null, null, null, null, null, null, "Spell 2", null, null, null, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6550) }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "ArmorClassModifier", "CharismaModifier", "CharismaSavingThrowModifier", "ConstitutionModifier", "ConstitutionSavingThrowModifier", "CreatedOn", "Description", "DexterityModifier", "DexteritySavingThrowModifier", "HitPointsModifier", "Immunities", "IntelligenceModifier", "IntelligenceSavingThrowModifier", "IsAcrobaticsProficient", "IsAnimalHandlingProficient", "IsArcanaProficient", "IsAthleticsProficient", "IsDeceptionProficient", "IsHistoryProficient", "IsInsightProficient", "IsIntimidationProficient", "IsInvestigationProficient", "IsMedicineProficient", "IsNatureProficient", "IsPerceptionProficient", "IsPerformanceProficient", "IsPersuasionProficient", "IsReligionProficient", "IsSleightOfHandProficient", "IsStealthProficient", "IsSurvivalProficient", "Name", "ProficiencyBonusModifier", "RaceId", "Resistances", "SpeedModifier", "StrengthModifier", "StrengthSavingThrowModifier", "TemporaryHitPointsModifier", "UpdatedOn", "Vulnerabilities", "WisdomModifier", "WisdomSavingThrowModifier" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6440), "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Draconic Ancestry", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6450), "", 0, 0 },
                    { 2, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "You can use your action to exhale destructive energy.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Breath Weapon", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "", 0, 0 },
                    { 3, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "Accustomed to life underground, you have superior vision in dark and dim conditions.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Darkvision", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "", 0, 0 },
                    { 4, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "You have advantage on saving throws against poison and resistance against poison damage.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Dwarven Resilience", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6470), "", 0, 0 },
                    { 5, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "You have advantage on saving throws against being charmed, and magic can't put you to sleep.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Fey Ancestry", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "", 0, 0 },
                    { 6, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Gnome Cunning", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "", 0, 0 },
                    { 7, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "Your Charisma score increases by 2, and two other ability scores of your choice increase by 1.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Ability Score Increase", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "", 0, 0 },
                    { 8, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Relentless Endurance", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6480), "", 0, 0 },
                    { 9, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Lucky", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "", 0, 0 },
                    { 10, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "You have advantage on saving throws against being frightened.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Brave", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "", 0, 0 },
                    { 11, 0, 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "You have resistance to fire damage.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, "Hellish Resistance", 0, null, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6490), "", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Acrobatics", "Age", "Alignment", "AnimalHandling", "Arcana", "ArmorClass", "Athletics", "Background", "CampaignId", "Charisma", "CharismaSavingThrow", "Constitution", "ConstitutionSavingThrow", "CreatedOn", "CurrentHitPoints", "Deception", "Dexterity", "DexteritySavingThrow", "ExperiencePoints", "Eyes", "Hair", "Height", "History", "Immunities", "Insight", "Intelligence", "IntelligenceSavingThrow", "Intimidation", "Investigation", "IsAcrobaticsProficient", "IsAnimalHandlingProficient", "IsArcanaProficient", "IsAthleticsProficient", "IsDeceptionProficient", "IsHistoryProficient", "IsInsightProficient", "IsIntimidationProficient", "IsInvestigationProficient", "IsMedicineProficient", "IsNatureProficient", "IsPerceptionProficient", "IsPerformanceProficient", "IsPersuasionProficient", "IsPlayerCharacter", "IsReligionProficient", "IsSleightOfHandProficient", "IsStealthProficient", "IsSurvivalProficient", "Level", "MaxHitPoints", "Medicine", "Name", "Nature", "Perception", "Performance", "Persuasion", "ProficiencyBonus", "RaceId", "Religion", "Resistances", "Sex", "Skin", "SleightOfHand", "Speed", "Stealth", "Strength", "StrengthSavingThrow", "Survival", "TemporaryHitPoints", "TokenId", "UpdatedOn", "VoiceId", "Vulnerabilities", "Weight", "Wisdom", "WisdomSavingThrow" },
                values: new object[,]
                {
                    { 1, 0, "", "", 0, 0, 10, 0, "", null, 10, 0, 10, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6610), 10, 0, 10, 0, 0, "", "", "", 0, "", 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Grondar", 0, 0, 0, 0, 0, 1, 0, "", "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6610), null, "", "", 10, 0 },
                    { 2, 0, "", "", 0, 0, 10, 0, "", null, 10, 0, 10, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6620), 10, 0, 10, 0, 0, "", "", "", 0, "", 0, 10, 0, 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, 10, 0, "Zander", 0, 0, 0, 0, 0, 2, 0, "", "", "", 0, 15, 0, 10, 0, 0, 0, null, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6620), null, "", "", 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "ArmorClassModifier", "CharismaModifier", "CharismaSavingThrowModifier", "ClassId", "ConstitutionModifier", "ConstitutionSavingThrowModifier", "CreatedOn", "Description", "DexterityModifier", "DexteritySavingThrowModifier", "HitPointsModifier", "Immunities", "IntelligenceModifier", "IntelligenceSavingThrowModifier", "IsAcrobaticsProficient", "IsAnimalHandlingProficient", "IsArcanaProficient", "IsAthleticsProficient", "IsDeceptionProficient", "IsHistoryProficient", "IsInsightProficient", "IsIntimidationProficient", "IsInvestigationProficient", "IsMedicineProficient", "IsNatureProficient", "IsPerceptionProficient", "IsPerformanceProficient", "IsPersuasionProficient", "IsReligionProficient", "IsSleightOfHandProficient", "IsStealthProficient", "IsSurvivalProficient", "Level", "Name", "ProficiencyBonusModifier", "Resistances", "SpeedModifier", "StrengthModifier", "StrengthSavingThrowModifier", "TemporaryHitPointsModifier", "UpdatedOn", "Vulnerabilities", "WisdomModifier", "WisdomSavingThrowModifier" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 1, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6260), "In battle, you fight with primal ferocity. On your turn, you can enter a rage as a bonus action.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Rage", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6270), "", 0, 0 },
                    { 2, 0, 0, 0, 1, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6290), "While you are not wearing any armor, your AC equals 10 + your Dexterity modifier + your Constitution modifier.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Unarmored Defense", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6290), "", 0, 0 },
                    { 3, 0, 0, 0, 2, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "You can inspire others through stirring words or music. As a bonus action, you can choose one creature within 60 feet.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Bardic Inspiration", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "", 0, 0 },
                    { 4, 0, 0, 0, 2, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Spellcasting", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "", 0, 0 },
                    { 5, 0, 0, 0, 3, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "Choose a divine domain, such as Life or Tempest, that grants you domain spells and other features.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Divine Domain", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "", 0, 0 },
                    { 6, 0, 0, 0, 3, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6300), "At 2nd level, you gain the ability to channel divine energy directly from your deity.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Channel Divinity", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "", 0, 0 },
                    { 7, 0, 0, 0, 4, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "You know Druidic, the secret language of druids. You can speak the language and use it to leave hidden messages.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Druidic", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "", 0, 0 },
                    { 8, 0, 0, 0, 4, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "Drawing on the divine essence of nature itself, you can cast spells to shape that essence to your will.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Spellcasting", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "", 0, 0 },
                    { 9, 0, 0, 0, 5, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "You adopt a particular style of fighting as your specialty. Choose one of the following options.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Fighting Style", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6310), "", 0, 0 },
                    { 10, 0, 0, 0, 5, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "You have a limited well of stamina that you can draw on to protect yourself from harm.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Second Wind", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "", 0, 0 },
                    { 11, 0, 0, 0, 6, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "While you are wearing no armor and not wielding a shield, your AC equals 10 + your Dexterity modifier + your Wisdom modifier.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Unarmored Defense", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "", 0, 0 },
                    { 12, 0, 0, 0, 6, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "Your practice of martial arts gives you mastery of combat styles that use unarmed strikes and monk weapons.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Martial Arts", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6320), "", 0, 0 },
                    { 13, 0, 0, 0, 7, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "The presence of strong evil registers on your senses like a noxious odor, and powerful good rings like heavenly music in your ears.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Divine Sense", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "", 0, 0 },
                    { 14, 0, 0, 0, 7, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "Your blessed touch can heal wounds. You have a pool of healing power that replenishes when you take a long rest.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Lay on Hands", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "", 0, 0 },
                    { 15, 0, 0, 0, 8, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "Beginning at 1st level, you have significant experience studying, tracking, hunting, and even talking to a certain type of enemy.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Favored Enemy", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6330), "", 0, 0 },
                    { 16, 0, 0, 0, 8, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "You are a master of navigating the natural world and have a deep understanding of the terrain.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Natural Explorer", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "", 0, 0 },
                    { 17, 0, 0, 0, 9, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "Beginning at 1st level, you know how to strike subtly and exploit a foe's distraction.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Sneak Attack", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "", 0, 0 },
                    { 18, 0, 0, 0, 9, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "During your rogue training, you learned thieves' cant, a secret mix of dialect, jargon, and code that allows you to hide messages.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Thieves' Cant", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "", 0, 0 },
                    { 19, 0, 0, 0, 10, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "Choose a sorcerous origin, which describes the source of your innate magical power.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Sorcerous Origin", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6340), "", 0, 0 },
                    { 20, 0, 0, 0, 10, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "An event in your past, or in the life of a parent or ancestor, left an indelible mark on you, infusing you with arcane magic.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Spellcasting", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "", 0, 0 },
                    { 21, 0, 0, 0, 11, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "At 1st level, you have struck a bargain with an otherworldly being of your choice.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Otherworldly Patron", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "", 0, 0 },
                    { 22, 0, 0, 0, 11, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "Your arcane research and the magic bestowed on you by your patron have given you facility with spells.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Pact Magic", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6350), "", 0, 0 },
                    { 23, 0, 0, 0, 12, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6360), "As a student of arcane magic, you have a spellbook containing spells that show the first glimmerings of your true power.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Spellcasting", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6360), "", 0, 0 },
                    { 24, 0, 0, 0, 12, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6360), "You have learned to regain some of your magical energy by studying your spellbook.", 0, 0, 0, "", 0, 0, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, 1, "Arcane Recovery", 0, "", 0, 0, 0, 0, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6360), "", 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "GuildClass",
                columns: new[] { "CharacterClassId", "GuildId" },
                values: new object[,]
                {
                    { 1, 1077311704985239684L },
                    { 2, 1077311704985239684L },
                    { 3, 1077311704985239684L },
                    { 4, 1077311704985239684L },
                    { 5, 1077311704985239684L },
                    { 6, 1077311704985239684L },
                    { 7, 1077311704985239684L },
                    { 8, 1077311704985239684L },
                    { 9, 1077311704985239684L },
                    { 10, 1077311704985239684L },
                    { 11, 1077311704985239684L },
                    { 12, 1077311704985239684L }
                });

            migrationBuilder.InsertData(
                table: "GuildRace",
                columns: new[] { "CharacterRaceId", "GuildId" },
                values: new object[,]
                {
                    { 1, 1077311704985239684L },
                    { 2, 1077311704985239684L },
                    { 3, 1077311704985239684L },
                    { 4, 1077311704985239684L },
                    { 5, 1077311704985239684L },
                    { 6, 1077311704985239684L },
                    { 7, 1077311704985239684L },
                    { 8, 1077311704985239684L },
                    { 9, 1077311704985239684L }
                });

            migrationBuilder.InsertData(
                table: "CharacterAlly",
                columns: new[] { "AllyId", "CharacterId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterClassCharacter",
                columns: new[] { "CharacterClassId", "CharacterId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

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
                    { 1, 1077311704985239684L, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6750) },
                    { 2, 1077311704985239684L, new DateTime(2023, 7, 20, 19, 25, 19, 122, DateTimeKind.Utc).AddTicks(6750) }
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
                name: "IX_DiscordGuildChannels_GuildId",
                table: "DiscordGuildChannels",
                column: "GuildId");

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
                name: "IX_Sessions_CampaignId",
                table: "Sessions",
                column: "CampaignId");

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
                name: "DiscordGuildChannels");

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
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "CharacterTokens");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Voices");

            migrationBuilder.DropTable(
                name: "DiscordGuilds");
        }
    }
}
