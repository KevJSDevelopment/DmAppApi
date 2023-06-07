using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCharacterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Characters");
        }
    }
}
