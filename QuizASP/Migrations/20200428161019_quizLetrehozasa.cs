using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizASP.Migrations
{
    public partial class quizLetrehozasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "quiz",
                columns: table => new
                {
                    Kerdes_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kerdes = table.Column<string>(nullable: true),
                    Valasz_A = table.Column<string>(nullable: true),
                    Valasz_B = table.Column<string>(nullable: true),
                    Valasz_C = table.Column<string>(nullable: true),
                    Valasz_D = table.Column<string>(nullable: true),
                    Helyes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quiz", x => x.Kerdes_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quiz");
        }
    }
}
