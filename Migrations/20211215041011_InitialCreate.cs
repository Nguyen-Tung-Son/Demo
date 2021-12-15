using Microsoft.EntityFrameworkCore.Migrations;

namespace TungSon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTS",
                columns: table => new
                {
                    NTSID = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NTSname = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTS", x => x.NTSID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTS");
        }
    }
}
