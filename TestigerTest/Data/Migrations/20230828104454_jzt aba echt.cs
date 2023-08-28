using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestigerTest.Data.Migrations
{
    public partial class jztabaecht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_TreatmentArticles_TreatmentArticleID",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_TreatmentArticles_TreatmentArticleID",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_TreatmentArticleID",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TreatmentArticleID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TreatmentArticleID",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "TreatmentArticleID",
                table: "Articles");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentArticles_ArticleID",
                table: "TreatmentArticles",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentArticles_TreatmentID",
                table: "TreatmentArticles",
                column: "TreatmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentArticles_Articles_ArticleID",
                table: "TreatmentArticles",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreatmentArticles_Treatments_TreatmentID",
                table: "TreatmentArticles",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentArticles_Articles_ArticleID",
                table: "TreatmentArticles");

            migrationBuilder.DropForeignKey(
                name: "FK_TreatmentArticles_Treatments_TreatmentID",
                table: "TreatmentArticles");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentArticles_ArticleID",
                table: "TreatmentArticles");

            migrationBuilder.DropIndex(
                name: "IX_TreatmentArticles_TreatmentID",
                table: "TreatmentArticles");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentArticleID",
                table: "Treatments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentArticleID",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TreatmentArticleID",
                table: "Treatments",
                column: "TreatmentArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TreatmentArticleID",
                table: "Articles",
                column: "TreatmentArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_TreatmentArticles_TreatmentArticleID",
                table: "Articles",
                column: "TreatmentArticleID",
                principalTable: "TreatmentArticles",
                principalColumn: "TreatmentArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_TreatmentArticles_TreatmentArticleID",
                table: "Treatments",
                column: "TreatmentArticleID",
                principalTable: "TreatmentArticles",
                principalColumn: "TreatmentArticleID");
        }
    }
}
