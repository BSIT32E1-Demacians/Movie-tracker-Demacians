using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupActivity.Migrations
{
    /// <inheritdoc />
    public partial class SabiKo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Genre", "ReleaseYear", "Title" },
                values: new object[] { 11, "Comedy", 2020, "Sabi KO Sabi Ni Gelo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 11);
        }
    }
}
