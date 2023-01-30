using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishWordSet.Migrations
{
    public partial class LearnedWordTable_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LearnedWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wordEnglish = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    wordTurkish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wordSentence = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearnedWords", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LearnedWords_wordEnglish",
                table: "LearnedWords",
                column: "wordEnglish",
                unique: true,
                filter: "[wordEnglish] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LearnedWords");
        }
    }
}
