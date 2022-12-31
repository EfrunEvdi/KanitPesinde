using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_AccussedTwoForeignKeyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvestigationTwos_AccussedTwos_AccussedTwoID",
                table: "InvestigationTwos");

            migrationBuilder.DropIndex(
                name: "IX_InvestigationTwos_AccussedTwoID",
                table: "InvestigationTwos");

            migrationBuilder.DropColumn(
                name: "AccussedTwoID",
                table: "InvestigationTwos");

            migrationBuilder.AddColumn<int>(
                name: "InvestigationTwoID",
                table: "AccussedTwos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccussedTwos_InvestigationTwoID",
                table: "AccussedTwos",
                column: "InvestigationTwoID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccussedTwos_InvestigationTwos_InvestigationTwoID",
                table: "AccussedTwos",
                column: "InvestigationTwoID",
                principalTable: "InvestigationTwos",
                principalColumn: "InvestigationTwoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccussedTwos_InvestigationTwos_InvestigationTwoID",
                table: "AccussedTwos");

            migrationBuilder.DropIndex(
                name: "IX_AccussedTwos_InvestigationTwoID",
                table: "AccussedTwos");

            migrationBuilder.DropColumn(
                name: "InvestigationTwoID",
                table: "AccussedTwos");

            migrationBuilder.AddColumn<int>(
                name: "AccussedTwoID",
                table: "InvestigationTwos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InvestigationTwos_AccussedTwoID",
                table: "InvestigationTwos",
                column: "AccussedTwoID");

            migrationBuilder.AddForeignKey(
                name: "FK_InvestigationTwos_AccussedTwos_AccussedTwoID",
                table: "InvestigationTwos",
                column: "AccussedTwoID",
                principalTable: "AccussedTwos",
                principalColumn: "AccussedTwoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
