using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_Famillies_FamilyID",
                table: "articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Famillies",
                table: "Famillies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_articles",
                table: "articles");

            migrationBuilder.RenameTable(
                name: "Famillies",
                newName: "Familly");

            migrationBuilder.RenameTable(
                name: "articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_articles_FamilyID",
                table: "Article",
                newName: "IX_Article_FamilyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Familly",
                table: "Familly",
                column: "idFamilly");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "idArticle");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Familly_FamilyID",
                table: "Article",
                column: "FamilyID",
                principalTable: "Familly",
                principalColumn: "idFamilly");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Familly_FamilyID",
                table: "Article");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Familly",
                table: "Familly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Familly",
                newName: "Famillies");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_FamilyID",
                table: "articles",
                newName: "IX_articles_FamilyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Famillies",
                table: "Famillies",
                column: "idFamilly");

            migrationBuilder.AddPrimaryKey(
                name: "PK_articles",
                table: "articles",
                column: "idArticle");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_Famillies_FamilyID",
                table: "articles",
                column: "FamilyID",
                principalTable: "Famillies",
                principalColumn: "idFamilly");
        }
    }
}
