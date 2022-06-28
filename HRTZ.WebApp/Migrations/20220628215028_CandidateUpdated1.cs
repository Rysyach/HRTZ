using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    public partial class CandidateUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Candidates",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Candidates",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Candidates");
        }
    }
}
