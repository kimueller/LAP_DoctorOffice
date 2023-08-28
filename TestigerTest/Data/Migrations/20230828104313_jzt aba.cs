using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestigerTest.Data.Migrations
{
    public partial class jztaba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTreatmentArticle");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentArticleID",
                table: "Articles",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_TreatmentArticles_TreatmentArticleID",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TreatmentArticleID",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TreatmentArticleID",
                table: "Articles");

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

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTreatmentArticle_TreatmentArticlesTreatmentArticleID",
                table: "ArticleTreatmentArticle",
                column: "TreatmentArticlesTreatmentArticleID");
        }
    }
}
