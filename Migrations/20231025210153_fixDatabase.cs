using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokemonReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Pokemon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
