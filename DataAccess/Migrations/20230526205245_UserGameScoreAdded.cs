using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnglishWordSet.Migrations
{
    /// <inheritdoc />
    public partial class UserGameScoreAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_UserGameScores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastLetterGameBestScore = table.Column<int>(type: "int", nullable: false),
                    LastLetterGameScores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserGameScores", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_UserGameScores");
        }
    }
}
