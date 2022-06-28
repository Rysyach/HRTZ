using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    public partial class AdminCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Candidates",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_AdminId",
                table: "Candidates",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Admins_AdminId",
                table: "Candidates",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Admins_AdminId",
                table: "Candidates");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_AdminId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Candidates");
        }
    }
}
