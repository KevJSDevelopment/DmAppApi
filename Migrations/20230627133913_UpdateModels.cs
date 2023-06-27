using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "RacialTraits");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Traits",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3960), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3960), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3420), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3690), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3760), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3760), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Cost", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[] { 20, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880), "A short bow", "Short bow", new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3720), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3720), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3640), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3640), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3660), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3670), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3910), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3910), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "RaceId", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), null, new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.CreateIndex(
                name: "IX_Traits_RaceId",
                table: "Traits",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "CharacterClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "CharacterRaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Traits_Races_RaceId",
                table: "Traits",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "CharacterRaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Traits_Races_RaceId",
                table: "Traits");

            migrationBuilder.DropIndex(
                name: "IX_Traits_RaceId",
                table: "Traits");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Traits");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "Items",
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
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 192, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 6, 25, 17, 42, 18, 192, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(580), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "Cost", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[] { 0, new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(590), "", "", new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(600), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 6, 25, 17, 42, 18, 193, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.CreateIndex(
                name: "IX_RacialTraits_RaceId",
                table: "RacialTraits",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Classes_ClassId",
                table: "Characters",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "CharacterClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "CharacterRaceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
