using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingChannelModelValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1590), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(860), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(860), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1210), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1470), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1470), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1260), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1420), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 7, 15, 20, 46, 49, 679, DateTimeKind.Utc).AddTicks(1450) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9050), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 7, 15, 20, 44, 37, 388, DateTimeKind.Utc).AddTicks(9690) });
        }
    }
}
