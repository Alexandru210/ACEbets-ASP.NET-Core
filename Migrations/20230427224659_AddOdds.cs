using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ACEbets.Migrations
{
    /// <inheritdoc />
    public partial class AddOdds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AwayOdds",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "DrawOdds",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "HomeOdds",
                table: "Games",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwayOdds",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "DrawOdds",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "HomeOdds",
                table: "Games");
        }
    }
}
