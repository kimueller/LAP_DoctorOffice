using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestigerTest.Data.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreatmentID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(7,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleID);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentArticles",
                columns: table => new
                {
                    TreatmentArticleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreatmentID = table.Column<int>(type: "int", nullable: false),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentArticles", x => x.TreatmentArticleID);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTreatmentArticle",
                columns: table => new
                {
                    ArticlesArticleID = table.Column<int>(type: "int", nullable: false),
                    TreatmentArticlesTreatmentArticleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTreatmentArticle", x => new { x.ArticlesArticleID, x.TreatmentArticlesTreatmentArticleID });
                    table.ForeignKey(
                        name: "FK_ArticleTreatmentArticle_Articles_ArticlesArticleID",
                        column: x => x.ArticlesArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTreatmentArticle_TreatmentArticles_TreatmentArticlesTreatmentArticleID",
                        column: x => x.TreatmentArticlesTreatmentArticleID,
                        principalTable: "TreatmentArticles",
                        principalColumn: "TreatmentArticleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreatmentArticleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentID);
                    table.ForeignKey(
                        name: "FK_Treatments_TreatmentArticles_TreatmentArticleID",
                        column: x => x.TreatmentArticleID,
                        principalTable: "TreatmentArticles",
                        principalColumn: "TreatmentArticleID");
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_People_Treatments_TreatmentID",
                        column: x => x.TreatmentID,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TreatmentID",
                table: "AspNetUsers",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTreatmentArticle_TreatmentArticlesTreatmentArticleID",
                table: "ArticleTreatmentArticle",
                column: "TreatmentArticlesTreatmentArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_People_TreatmentID",
                table: "People",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TreatmentArticleID",
                table: "Treatments",
                column: "TreatmentArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Treatments_TreatmentID",
                table: "AspNetUsers",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Treatments_TreatmentID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ArticleTreatmentArticle");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "TreatmentArticles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TreatmentID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TreatmentID",
                table: "AspNetUsers");
        }
    }
}
