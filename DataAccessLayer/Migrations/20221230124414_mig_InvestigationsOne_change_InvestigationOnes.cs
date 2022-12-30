using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_InvestigationsOne_change_InvestigationOnes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationsOne_AccussedOnes_AccussedOneID",
                table: "InvestigationsOne");

            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationsTwo_AccussedTwos_AccussedTwoID",
                table: "InvestigationsTwo");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOnes_InvestigationsOne_InvestigationOneID",
                table: "QuestionOnes");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTwos_InvestigationsTwo_InvestigationTwoID",
                table: "QuestionTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationsTwo",
                table: "InvestigationsTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationsOne",
                table: "InvestigationsOne");

            migrationBuilder.RenameTable(
                name: "InvestigationsTwo",
                newName: "InvestigationTwos");

            migrationBuilder.RenameTable(
                name: "InvestigationsOne",
                newName: "InvestigationOnes");

            migrationBuilder.RenameIndex(
                name: "IX_InvestigationsTwo_AccussedTwoID",
                table: "InvestigationTwos",
                newName: "IX_InvestigationTwos_AccussedTwoID");

            migrationBuilder.RenameIndex(
                name: "IX_InvestigationsOne_AccussedOneID",
                table: "InvestigationOnes",
                newName: "IX_InvestigationOnes_AccussedOneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationTwos",
                table: "InvestigationTwos",
                column: "InvestigationTwoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationOnes",
                table: "InvestigationOnes",
                column: "InvestigationOneID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationOnes_AccussedOnes_AccussedOneID",
                table: "InvestigationOnes",
                column: "AccussedOneID",
                principalTable: "AccussedOnes",
                principalColumn: "AccussedOneID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationTwos_AccussedTwos_AccussedTwoID",
                table: "InvestigationTwos",
                column: "AccussedTwoID",
                principalTable: "AccussedTwos",
                principalColumn: "AccussedTwoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOnes_InvestigationOnes_InvestigationOneID",
                table: "QuestionOnes",
                column: "InvestigationOneID",
                principalTable: "InvestigationOnes",
                principalColumn: "InvestigationOneID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTwos_InvestigationTwos_InvestigationTwoID",
                table: "QuestionTwos",
                column: "InvestigationTwoID",
                principalTable: "InvestigationTwos",
                principalColumn: "InvestigationTwoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationOnes_AccussedOnes_AccussedOneID",
                table: "InvestigationOnes");

            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationTwos_AccussedTwos_AccussedTwoID",
                table: "InvestigationTwos");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOnes_InvestigationOnes_InvestigationOneID",
                table: "QuestionOnes");

            migrationBuilder.DropForeignKey(
                name: "FK_QuestionTwos_InvestigationTwos_InvestigationTwoID",
                table: "QuestionTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationTwos",
                table: "InvestigationTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvestigationOnes",
                table: "InvestigationOnes");

            migrationBuilder.RenameTable(
                name: "InvestigationTwos",
                newName: "InvestigationsTwo");

            migrationBuilder.RenameTable(
                name: "InvestigationOnes",
                newName: "InvestigationsOne");

            migrationBuilder.RenameIndex(
                name: "IX_InvestigationTwos_AccussedTwoID",
                table: "InvestigationsTwo",
                newName: "IX_InvestigationsTwo_AccussedTwoID");

            migrationBuilder.RenameIndex(
                name: "IX_InvestigationOnes_AccussedOneID",
                table: "InvestigationsOne",
                newName: "IX_InvestigationsOne_AccussedOneID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationsTwo",
                table: "InvestigationsTwo",
                column: "InvestigationTwoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvestigationsOne",
                table: "InvestigationsOne",
                column: "InvestigationOneID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationsOne_AccussedOnes_AccussedOneID",
                table: "InvestigationsOne",
                column: "AccussedOneID",
                principalTable: "AccussedOnes",
                principalColumn: "AccussedOneID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationsTwo_AccussedTwos_AccussedTwoID",
                table: "InvestigationsTwo",
                column: "AccussedTwoID",
                principalTable: "AccussedTwos",
                principalColumn: "AccussedTwoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOnes_InvestigationsOne_InvestigationOneID",
                table: "QuestionOnes",
                column: "InvestigationOneID",
                principalTable: "InvestigationsOne",
                principalColumn: "InvestigationOneID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionTwos_InvestigationsTwo_InvestigationTwoID",
                table: "QuestionTwos",
                column: "InvestigationTwoID",
                principalTable: "InvestigationsTwo",
                principalColumn: "InvestigationTwoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
