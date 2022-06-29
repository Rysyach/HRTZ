using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRTZ.WebApp.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminCandidate_Admins_TesteresId",
                table: "AdminCandidate");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_Candidates_LikesId",
                table: "CandidateUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateUser",
                table: "CandidateUser");

            migrationBuilder.DropIndex(
                name: "IX_CandidateUser_LikesId",
                table: "CandidateUser");

            migrationBuilder.RenameColumn(
                name: "LikesId",
                table: "CandidateUser",
                newName: "CandidatesOnTestId");

            migrationBuilder.RenameColumn(
                name: "TesteresId",
                table: "AdminCandidate",
                newName: "TestersId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminCandidate_TesteresId",
                table: "AdminCandidate",
                newName: "IX_AdminCandidate_TestersId");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeclined",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateUser",
                table: "CandidateUser",
                columns: new[] { "CandidatesOnTestId", "LikedById" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateUser_LikedById",
                table: "CandidateUser",
                column: "LikedById");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminCandidate_Admins_TestersId",
                table: "AdminCandidate",
                column: "TestersId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_Candidates_CandidatesOnTestId",
                table: "CandidateUser",
                column: "CandidatesOnTestId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminCandidate_Admins_TestersId",
                table: "AdminCandidate");

            migrationBuilder.DropForeignKey(
                name: "FK_CandidateUser_Candidates_CandidatesOnTestId",
                table: "CandidateUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateUser",
                table: "CandidateUser");

            migrationBuilder.DropIndex(
                name: "IX_CandidateUser_LikedById",
                table: "CandidateUser");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IsDeclined",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "CandidatesOnTestId",
                table: "CandidateUser",
                newName: "LikesId");

            migrationBuilder.RenameColumn(
                name: "TestersId",
                table: "AdminCandidate",
                newName: "TesteresId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminCandidate_TestersId",
                table: "AdminCandidate",
                newName: "IX_AdminCandidate_TesteresId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateUser",
                table: "CandidateUser",
                columns: new[] { "LikedById", "LikesId" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateUser_LikesId",
                table: "CandidateUser",
                column: "LikesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminCandidate_Admins_TesteresId",
                table: "AdminCandidate",
                column: "TesteresId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateUser_Candidates_LikesId",
                table: "CandidateUser",
                column: "LikesId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
