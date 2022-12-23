using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_kurulum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutValueTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "DetectiveStories",
                columns: table => new
                {
                    DetectiveStoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetectiveTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectiveDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectiveImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectiveTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectiveDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectiveImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetectiveStories", x => x.DetectiveStoryID);
                });

            migrationBuilder.CreateTable(
                name: "FindKillers",
                columns: table => new
                {
                    FindKillerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindKillerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindKillerClose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindKillerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindKillerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FindKillers", x => x.FindKillerID);
                });

            migrationBuilder.CreateTable(
                name: "Intros",
                columns: table => new
                {
                    IntroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntroTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntroDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intros", x => x.IntroID);
                });

            migrationBuilder.CreateTable(
                name: "SceneOnes",
                columns: table => new
                {
                    SceneOneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SceneOneTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneOneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneOneImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneOnes", x => x.SceneOneID);
                });

            migrationBuilder.CreateTable(
                name: "SceneTwos",
                columns: table => new
                {
                    SceneTwoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SceneTwoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneTwoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SceneTwoImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneTwos", x => x.SceneTwoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DetectiveStories");

            migrationBuilder.DropTable(
                name: "FindKillers");

            migrationBuilder.DropTable(
                name: "Intros");

            migrationBuilder.DropTable(
                name: "SceneOnes");

            migrationBuilder.DropTable(
                name: "SceneTwos");
        }
    }
}
