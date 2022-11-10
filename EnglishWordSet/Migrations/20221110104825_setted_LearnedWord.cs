using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishWordSet.Migrations
{
    public partial class setted_LearnedWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LearnedWords_wordEnglish",
                table: "LearnedWords");

            migrationBuilder.RenameColumn(
                name: "wordTurkish",
                table: "LearnedWords",
                newName: "learnedWord_meanig");

            migrationBuilder.RenameColumn(
                name: "wordSentence",
                table: "LearnedWords",
                newName: "learnedWord_sentence");

            migrationBuilder.RenameColumn(
                name: "wordEnglish",
                table: "LearnedWords",
                newName: "learnedWord_word");

            migrationBuilder.AddColumn<string>(
                name: "learnedWord_meanigSentence",
                table: "LearnedWords",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LearnedWords_learnedWord_word",
                table: "LearnedWords",
                column: "learnedWord_word",
                unique: true,
                filter: "[learnedWord_word] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LearnedWords_learnedWord_word",
                table: "LearnedWords");

            migrationBuilder.DropColumn(
                name: "learnedWord_meanigSentence",
                table: "LearnedWords");

            migrationBuilder.RenameColumn(
                name: "learnedWord_word",
                table: "LearnedWords",
                newName: "wordEnglish");

            migrationBuilder.RenameColumn(
                name: "learnedWord_sentence",
                table: "LearnedWords",
                newName: "wordSentence");

            migrationBuilder.RenameColumn(
                name: "learnedWord_meanig",
                table: "LearnedWords",
                newName: "wordTurkish");

            migrationBuilder.CreateIndex(
                name: "IX_LearnedWords_wordEnglish",
                table: "LearnedWords",
                column: "wordEnglish",
                unique: true,
                filter: "[wordEnglish] IS NOT NULL");
        }
    }
}
