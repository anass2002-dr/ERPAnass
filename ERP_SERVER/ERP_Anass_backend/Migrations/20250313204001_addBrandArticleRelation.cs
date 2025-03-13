using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class addBrandArticleRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Article",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Article_BrandID",
                table: "Article",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Brand_BrandID",
                table: "Article",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Brand_BrandID",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_BrandID",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Article");
        }
    }
}
