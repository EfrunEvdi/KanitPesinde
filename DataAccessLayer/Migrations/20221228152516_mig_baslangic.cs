using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_baslangic : Migration
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
                name: "Accusseds1",
                columns: table => new
                {
                    AccussedOneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccussedOneNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccussedOneClose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccussedOneImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accusseds1", x => x.AccussedOneID);
                });

            migrationBuilder.CreateTable(
                name: "Accusseds2",
                columns: table => new
                {
                    AccussedTwoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccussedTwoNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccussedTwoClose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccussedTwoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accusseds2", x => x.AccussedTwoID);
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
                name: "InvestigationsOne",
                columns: table => new
                {
                    InvestigationOneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvOneNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOnePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneMaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneChildrenNo = table.Column<int>(type: "int", nullable: false),
                    InvOneDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvOneImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneOfficer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneClosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneQuestion20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvOneAnswer20 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationsOne", x => x.InvestigationOneID);
                });

            migrationBuilder.CreateTable(
                name: "InvestigationsTwo",
                columns: table => new
                {
                    InvestigationTwoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvTwoNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoMaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoChildrenNo = table.Column<int>(type: "int", nullable: false),
                    InvTwoDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvTwoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoOfficer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoClosed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoQuestion20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvTwoAnswer20 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationsTwo", x => x.InvestigationTwoID);
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
                name: "Accusseds1");

            migrationBuilder.DropTable(
                name: "Accusseds2");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DetectiveStories");

            migrationBuilder.DropTable(
                name: "FindKillers");

            migrationBuilder.DropTable(
                name: "Intros");

            migrationBuilder.DropTable(
                name: "InvestigationsOne");

            migrationBuilder.DropTable(
                name: "InvestigationsTwo");

            migrationBuilder.DropTable(
                name: "SceneOnes");

            migrationBuilder.DropTable(
                name: "SceneTwos");
        }
    }
}
