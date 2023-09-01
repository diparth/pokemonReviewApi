using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokemonReviewApp.Migrations
{
    /// <inheritdoc />
    public partial class countryUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonOwners_Countries_CountryId",
                table: "PokemonOwners");

            migrationBuilder.DropIndex(
                name: "IX_PokemonOwners_CountryId",
                table: "PokemonOwners");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "PokemonOwners");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "PokemonOwners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonOwners_CountryId",
                table: "PokemonOwners",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonOwners_Countries_CountryId",
                table: "PokemonOwners",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
