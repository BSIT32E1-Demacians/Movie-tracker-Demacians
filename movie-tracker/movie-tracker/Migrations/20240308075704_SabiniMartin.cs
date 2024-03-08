using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupActivity.Migrations
{
    /// <inheritdoc />
    public partial class SabiniMartin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "QuoteText" },
                values: new object[] { 11, "Literally Everyone Except Gojo Satoru", "Nah, I'd Win." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 11);
        }
    }
}
