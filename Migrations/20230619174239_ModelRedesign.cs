using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class ModelRedesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Classes_ClassId",
                table: "Features");

            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropTable(
                name: "BackgroundInfos");

            migrationBuilder.DropTable(
                name: "SavingThrows");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.RenameColumn(
                name: "SkillSetId",
                table: "Characters",
                newName: "WisdomSavingThrow");

            migrationBuilder.RenameColumn(
                name: "SavingThrowsId",
                table: "Characters",
                newName: "Wisdom");

            migrationBuilder.RenameColumn(
                name: "BackgroundInfoId",
                table: "Characters",
                newName: "Survival");

            migrationBuilder.RenameColumn(
                name: "AbilityScoreId",
                table: "Characters",
                newName: "StrengthSavingThrow");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Traits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Traits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Spells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Spells",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Races",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Races",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Features",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Features",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Classes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Classes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Classes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Acrobatics",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalHandling",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arcana",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Athletics",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Background",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Charisma",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharismaSavingThrow",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Constitution",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConstitutionSavingThrow",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Deception",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dexterity",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DexteritySavingThrow",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Eyes",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hair",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Height",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "History",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Insight",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IntelligenceSavingThrow",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Intimidation",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Investigation",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcrobaticsProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAnimalHandlingProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArcanaProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAthleticsProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeceptionProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHistoryProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInsightProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsIntimidationProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInvestigationProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMedicineProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNatureProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPerceptionProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPerformanceProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPersuasionProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReligionProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSleightOfHandProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsStealthProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSurvivalProficient",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Medicine",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nature",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Perception",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Performance",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Persuasion",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Religion",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skin",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SleightOfHand",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stealth",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Races_Name",
                table: "Races",
                column: "Name");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Classes_Name",
                table: "Classes",
                column: "Name");

            migrationBuilder.CreateTable(
                name: "CharacterRaceDiscordGuild",
                columns: table => new
                {
                    CharacterRacesCharacterRaceId = table.Column<int>(type: "int", nullable: false),
                    GuildsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRaceDiscordGuild", x => new { x.CharacterRacesCharacterRaceId, x.GuildsId });
                    table.ForeignKey(
                        name: "FK_CharacterRaceDiscordGuild_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterRaceDiscordGuild_Races_CharacterRacesCharacterRaceId",
                        column: x => x.CharacterRacesCharacterRaceId,
                        principalTable: "Races",
                        principalColumn: "CharacterRaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildFeature",
                columns: table => new
                {
                    FeaturesFeatureId = table.Column<int>(type: "int", nullable: false),
                    GuildsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildFeature", x => new { x.FeaturesFeatureId, x.GuildsId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildFeature_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildFeature_Features_FeaturesFeatureId",
                        column: x => x.FeaturesFeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildItem",
                columns: table => new
                {
                    GuildsId = table.Column<int>(type: "int", nullable: false),
                    ItemsItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildItem", x => new { x.GuildsId, x.ItemsItemId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildItem_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildItem_Items_ItemsItemId",
                        column: x => x.ItemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildOrganization",
                columns: table => new
                {
                    GuildsId = table.Column<int>(type: "int", nullable: false),
                    OrganizationsOrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildOrganization", x => new { x.GuildsId, x.OrganizationsOrganizationId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildOrganization_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildOrganization_Organizations_OrganizationsOrganizationId",
                        column: x => x.OrganizationsOrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildSpell",
                columns: table => new
                {
                    GuildsId = table.Column<int>(type: "int", nullable: false),
                    SpellsSpellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildSpell", x => new { x.GuildsId, x.SpellsSpellId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildSpell_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildSpell_Spells_SpellsSpellId",
                        column: x => x.SpellsSpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscordGuildTrait",
                columns: table => new
                {
                    GuildsId = table.Column<int>(type: "int", nullable: false),
                    TraitsTraitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscordGuildTrait", x => new { x.GuildsId, x.TraitsTraitId });
                    table.ForeignKey(
                        name: "FK_DiscordGuildTrait_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscordGuildTrait_Traits_TraitsTraitId",
                        column: x => x.TraitsTraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRaceDiscordGuild_GuildsId",
                table: "CharacterRaceDiscordGuild",
                column: "GuildsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildFeature_GuildsId",
                table: "DiscordGuildFeature",
                column: "GuildsId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildItem_ItemsItemId",
                table: "DiscordGuildItem",
                column: "ItemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildOrganization_OrganizationsOrganizationId",
                table: "DiscordGuildOrganization",
                column: "OrganizationsOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildSpell_SpellsSpellId",
                table: "DiscordGuildSpell",
                column: "SpellsSpellId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildTrait_TraitsTraitId",
                table: "DiscordGuildTrait",
                column: "TraitsTraitId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildClass_ClassId",
                table: "GuildClass",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Classes_ClassId",
                table: "Features",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "CharacterClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Classes_ClassId",
                table: "Features");

            migrationBuilder.DropTable(
                name: "CharacterRaceDiscordGuild");

            migrationBuilder.DropTable(
                name: "DiscordGuildFeature");

            migrationBuilder.DropTable(
                name: "DiscordGuildItem");

            migrationBuilder.DropTable(
                name: "DiscordGuildOrganization");

            migrationBuilder.DropTable(
                name: "DiscordGuildSpell");

            migrationBuilder.DropTable(
                name: "DiscordGuildTrait");

            migrationBuilder.DropTable(
                name: "GuildClass");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Races_Name",
                table: "Races");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Classes_Name",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Traits");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Traits");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Acrobatics",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Alignment",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AnimalHandling",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Arcana",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Athletics",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Background",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Charisma",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharismaSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Constitution",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ConstitutionSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Deception",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Dexterity",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "DexteritySavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Eyes",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Hair",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Insight",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IntelligenceSavingThrow",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Intimidation",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Investigation",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsAcrobaticsProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsAnimalHandlingProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsArcanaProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsAthleticsProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsDeceptionProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsHistoryProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsInsightProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsIntimidationProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsInvestigationProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsMedicineProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsNatureProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsPerceptionProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsPerformanceProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsPersuasionProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsReligionProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsSleightOfHandProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsStealthProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "IsSurvivalProficient",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Medicine",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Nature",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Perception",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Performance",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Persuasion",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Skin",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SleightOfHand",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stealth",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "WisdomSavingThrow",
                table: "Characters",
                newName: "SkillSetId");

            migrationBuilder.RenameColumn(
                name: "Wisdom",
                table: "Characters",
                newName: "SavingThrowsId");

            migrationBuilder.RenameColumn(
                name: "Survival",
                table: "Characters",
                newName: "BackgroundInfoId");

            migrationBuilder.RenameColumn(
                name: "StrengthSavingThrow",
                table: "Characters",
                newName: "AbilityScoreId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Features",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    AbilityScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.AbilityScoreId);
                    table.ForeignKey(
                        name: "FK_AbilityScores_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundInfos",
                columns: table => new
                {
                    BackgroundInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundInfos", x => x.BackgroundInfoId);
                    table.ForeignKey(
                        name: "FK_BackgroundInfos_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    SavingThrowsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Charisma = table.Column<int>(type: "int", nullable: false),
                    Constitution = table.Column<int>(type: "int", nullable: false),
                    Dexterity = table.Column<int>(type: "int", nullable: false),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Wisdom = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.SavingThrowsId);
                    table.ForeignKey(
                        name: "FK_SavingThrows_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
                columns: table => new
                {
                    SkillSetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Acrobatics = table.Column<int>(type: "int", nullable: false),
                    AnimalHandling = table.Column<int>(type: "int", nullable: false),
                    Arcana = table.Column<int>(type: "int", nullable: false),
                    Athletics = table.Column<int>(type: "int", nullable: false),
                    Deception = table.Column<int>(type: "int", nullable: false),
                    History = table.Column<int>(type: "int", nullable: false),
                    Insight = table.Column<int>(type: "int", nullable: false),
                    Intimidation = table.Column<int>(type: "int", nullable: false),
                    Investigation = table.Column<int>(type: "int", nullable: false),
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
                    Medicine = table.Column<int>(type: "int", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    Perception = table.Column<int>(type: "int", nullable: false),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    Persuasion = table.Column<int>(type: "int", nullable: false),
                    Religion = table.Column<int>(type: "int", nullable: false),
                    SleightOfHand = table.Column<int>(type: "int", nullable: false),
                    Stealth = table.Column<int>(type: "int", nullable: false),
                    Survival = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSets", x => x.SkillSetId);
                    table.ForeignKey(
                        name: "FK_SkillSets_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityScores_CharacterId",
                table: "AbilityScores",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundInfos_CharacterId",
                table: "BackgroundInfos",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavingThrows_CharacterId",
                table: "SavingThrows",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_CharacterId",
                table: "SkillSets",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Classes_ClassId",
                table: "Features",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "CharacterClassId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
