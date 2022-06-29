using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    public partial class AdminCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Admins_AdminId",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_AdminId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Candidates");

            migrationBuilder.CreateTable(
                name: "AdminCandidate",
                columns: table => new
                {
                    CandidatesOnTestId = table.Column<int>(type: "INTEGER", nullable: false),
                    TesteresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCandidate", x => new { x.CandidatesOnTestId, x.TesteresId });
                    table.ForeignKey(
                        name: "FK_AdminCandidate_Admins_TesteresId",
                        column: x => x.TesteresId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminCandidate_Candidates_CandidatesOnTestId",
                        column: x => x.CandidatesOnTestId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminCandidate_TesteresId",
                table: "AdminCandidate",
                column: "TesteresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCandidate");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Candidates",
                type: "INTEGER",
                nullable: true);

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
    }
}
