using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateCampaignSessionVoiceEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoiceId",
                table: "Characters",
                type: "int",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "CharacterGuild",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CampaignId", "CreatedOn", "UpdatedOn", "VoiceId" },
                values: new object[] { null, new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4440), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4440), null });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CampaignId", "CreatedOn", "UpdatedOn", "VoiceId" },
                values: new object[] { null, new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4450), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4450), null });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3730), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3760), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4100), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4170), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4220), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4220), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4340), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4340), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4150), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4000), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4380), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320), new DateTime(2023, 6, 30, 22, 53, 51, 34, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CampaignId",
                table: "Characters",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_VoiceId",
                table: "Characters",
                column: "VoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_GuildId",
                table: "Campaigns",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_campaignId",
                table: "Sessions",
                column: "campaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Voices_GuildId",
                table: "Voices",
                column: "GuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Campaigns_CampaignId",
                table: "Characters",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Voices_VoiceId",
                table: "Characters",
                column: "VoiceId",
                principalTable: "Voices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Campaigns_CampaignId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Voices_VoiceId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Voices");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CampaignId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_VoiceId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "VoiceId",
                table: "Characters");

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
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3880) });

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
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 6, 27, 13, 39, 13, 194, DateTimeKind.Utc).AddTicks(3870) });
        }
    }
}
