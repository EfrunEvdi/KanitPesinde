using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_accussedones_changetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Accusseds2",
                table: "Accusseds2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accusseds1",
                table: "Accusseds1");

            migrationBuilder.RenameTable(
                name: "Accusseds2",
                newName: "AccussedTwos");

            migrationBuilder.RenameTable(
                name: "Accusseds1",
                newName: "AccussedOnes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccussedTwos",
                table: "AccussedTwos",
                column: "AccussedTwoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccussedOnes",
                table: "AccussedOnes",
                column: "AccussedOneID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccussedTwos",
                table: "AccussedTwos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccussedOnes",
                table: "AccussedOnes");

            migrationBuilder.RenameTable(
                name: "AccussedTwos",
                newName: "Accusseds2");

            migrationBuilder.RenameTable(
                name: "AccussedOnes",
                newName: "Accusseds1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accusseds2",
                table: "Accusseds2",
                column: "AccussedTwoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accusseds1",
                table: "Accusseds1",
                column: "AccussedOneID");
        }
    }
}
