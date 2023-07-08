using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6950), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6960), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6200), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6230), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6230), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6560), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6680), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6680), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6690), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6730), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(7020));

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

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6870), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6870), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6530), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6530), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6760), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 7, 8, 18, 38, 27, 921, DateTimeKind.Utc).AddTicks(6840) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 3, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 4, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 5, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 6, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 7, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 8, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 9, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 10, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 11, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildClass",
                keyColumns: new[] { "CharacterClassId", "GuildId" },
                keyValues: new object[] { 12, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 3, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 4, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 5, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 6, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 7, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 8, 1077311704985239684L });

            migrationBuilder.DeleteData(
                table: "GuildRace",
                keyColumns: new[] { "CharacterRaceId", "GuildId" },
                keyValues: new object[] { 9, 1077311704985239684L });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 5, 14, 35, 22, 943, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 5, 14, 35, 22, 943, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9870), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9830), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 7, 5, 14, 35, 22, 942, DateTimeKind.Utc).AddTicks(9850) });
        }
    }
}
