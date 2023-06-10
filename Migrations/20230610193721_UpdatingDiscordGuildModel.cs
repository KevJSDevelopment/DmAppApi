using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingDiscordGuildModel : Migration
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
                    table.UniqueConstraint("AK_DiscordGuilds_GuildId", x => x.GuildId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TokenId = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "CharacterGuild",
                columns: table => new
                {
                    CharactersCharacterId = table.Column<int>(type: "int", nullable: false),
                    GuildsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGuild", x => new { x.CharactersCharacterId, x.GuildsId });
                    table.ForeignKey(
                        name: "FK_CharacterGuild_Characters_CharactersCharacterId",
                        column: x => x.CharactersCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterGuild_DiscordGuilds_GuildsId",
                        column: x => x.GuildsId,
                        principalTable: "DiscordGuilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGuild_GuildsId",
                table: "CharacterGuild",
                column: "GuildsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TokenId",
                table: "Characters",
                column: "TokenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterGuild");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "DiscordGuilds");

            migrationBuilder.DropTable(
                name: "CharacterTokens");
        }
    }
}
