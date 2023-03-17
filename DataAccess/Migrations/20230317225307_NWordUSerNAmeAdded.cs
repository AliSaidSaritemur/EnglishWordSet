using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWordSet.Migrations
{
    /// <inheritdoc />
    public partial class NWordUSerNAmeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "said");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Words");
        }
    }
}
