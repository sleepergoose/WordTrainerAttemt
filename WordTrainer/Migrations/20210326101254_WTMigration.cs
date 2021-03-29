using Microsoft.EntityFrameworkCore.Migrations;

namespace WordTrainer.Migrations
{
    public partial class WTMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    WordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transcription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamplesEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamplesRu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favourite = table.Column<bool>(type: "bit", nullable: true),
                    IsForgoten = table.Column<bool>(type: "bit", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.WordID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
