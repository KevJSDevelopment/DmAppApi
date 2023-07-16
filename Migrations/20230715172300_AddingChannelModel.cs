using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class AddingChannelModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscordGuildChannels",
                columns: table => new
                {
                    ChannelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChannelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAssetChannel = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9080), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 7, 15, 17, 22, 59, 752, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.CreateIndex(
                name: "IX_DiscordGuildChannels_GuildId",
                table: "DiscordGuildChannels",
                column: "GuildId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscordGuildChannels");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5330), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "CharacterClassId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "DiscordGuilds",
                keyColumn: "GuildId",
                keyValue: 1077311704985239684L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5010), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5080), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5080), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 1, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "GuildCharacter",
                keyColumns: new[] { "CharacterId", "GuildId" },
                keyValues: new object[] { 2, 1077311704985239684L },
                column: "JoinedOn",
                value: new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5270), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4900), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4900), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "CharacterRaceId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Spells",
                keyColumn: "SpellId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5180), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Traits",
                keyColumn: "TraitId",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 7, 8, 19, 23, 41, 555, DateTimeKind.Utc).AddTicks(5230) });
        }
    }
}
