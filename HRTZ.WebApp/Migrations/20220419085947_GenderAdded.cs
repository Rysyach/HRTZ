using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    public partial class GenderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Candidates");
        }
    }
}
