using Microsoft.EntityFrameworkCore.Migrations;

namespace TungSon.Migrations
{
    public partial class Sinhvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sinhvien",
                columns: table => new
                {
                    SVId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    SVname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SVgender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinhvien", x => x.SVId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinhvien");
        }
    }
}
