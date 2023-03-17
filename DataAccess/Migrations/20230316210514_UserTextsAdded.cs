using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWordSet.Migrations
{
    /// <inheritdoc />
    public partial class UserTextsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_UserTexts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrashBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SavedConvertedWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastConvertedWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserTexts", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX__UserTexts_UserName",
                table: "_UserTexts",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_UserTexts");
        }
    }
}
