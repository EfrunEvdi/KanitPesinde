using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_saniklar : Migration
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
                    Accussed1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accussed1NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accussed1Close = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accussed1ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accusseds1", x => x.Accussed1ID);
                });

            migrationBuilder.CreateTable(
                name: "Accusseds2",
                columns: table => new
                {
                    Accussed2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accussed2NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accussed2Close = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accussed2ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accusseds2", x => x.Accussed2ID);
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
                name: "Investigations1",
                columns: table => new
                {
                    Investigation1ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inv1NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1ChildrenNo = table.Column<int>(type: "int", nullable: false),
                    Inv1Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inv1ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Officer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Question20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv1Answer20 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigations1", x => x.Investigation1ID);
                });

            migrationBuilder.CreateTable(
                name: "Investigations2",
                columns: table => new
                {
                    Investigation2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inv2NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2ChildrenNo = table.Column<int>(type: "int", nullable: false),
                    Inv2Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inv2ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Officer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Closed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Question20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inv2Answer20 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigations2", x => x.Investigation2ID);
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
                name: "Investigations1");

            migrationBuilder.DropTable(
                name: "Investigations2");

            migrationBuilder.DropTable(
                name: "SceneOnes");

            migrationBuilder.DropTable(
                name: "SceneTwos");
        }
    }
}
