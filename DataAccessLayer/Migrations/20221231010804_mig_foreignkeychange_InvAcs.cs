using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_foreignkeychange_InvAcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationOnes_AccussedOnes_AccussedOneID",
                table: "InvestigationOnes");

            migrationBuilder.DropIndex(
                name: "IX_InvestigationOnes_AccussedOneID",
                table: "InvestigationOnes");

            migrationBuilder.DropColumn(
                name: "AccussedOneID",
                table: "InvestigationOnes");

            migrationBuilder.AddColumn<int>(
                name: "InvestigationOneID",
                table: "AccussedOnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccussedOnes_InvestigationOneID",
                table: "AccussedOnes",
                column: "InvestigationOneID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccussedOnes_InvestigationOnes_InvestigationOneID",
                table: "AccussedOnes",
                column: "InvestigationOneID",
                principalTable: "InvestigationOnes",
                principalColumn: "InvestigationOneID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccussedOnes_InvestigationOnes_InvestigationOneID",
                table: "AccussedOnes");

            migrationBuilder.DropIndex(
                name: "IX_AccussedOnes_InvestigationOneID",
                table: "AccussedOnes");

            migrationBuilder.DropColumn(
                name: "InvestigationOneID",
                table: "AccussedOnes");

            migrationBuilder.AddColumn<int>(
                name: "AccussedOneID",
                table: "InvestigationOnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationOnes_AccussedOneID",
                table: "InvestigationOnes",
                column: "AccussedOneID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationOnes_AccussedOnes_AccussedOneID",
                table: "InvestigationOnes",
                column: "AccussedOneID",
                principalTable: "AccussedOnes",
                principalColumn: "AccussedOneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
