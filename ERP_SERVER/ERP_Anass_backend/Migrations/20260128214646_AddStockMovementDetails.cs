using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddStockMovementDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // All operations commented out because database is already in this state
            // but migration was not recorded in history.
            
            // migrationBuilder.DropForeignKey(...
            // migrationBuilder.RenameColumn(...
            // migrationBuilder.CreateTable(...
            // migrationBuilder.CreateIndex(...
            // migrationBuilder.AddForeignKey(...
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails");

            migrationBuilder.DropTable(
                name: "StockMovementDetails");

            migrationBuilder.RenameColumn(
                name: "IdPurchase",
                table: "Purchases",
                newName: "idPurchase");

            migrationBuilder.RenameColumn(
                name: "IdPurchase",
                table: "PurchaseDetails",
                newName: "idPurchase");

            migrationBuilder.RenameColumn(
                name: "IdPurchaseDetails",
                table: "PurchaseDetails",
                newName: "idPurchaseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetails_IdPurchase",
                table: "PurchaseDetails",
                newName: "IX_PurchaseDetails_idPurchase");

            migrationBuilder.AddColumn<int>(
                name: "ArticleID",
                table: "StockMovements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "StockMovements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ArticleID",
                table: "StockMovements",
                column: "ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Purchases_idPurchase",
                table: "PurchaseDetails",
                column: "idPurchase",
                principalTable: "Purchases",
                principalColumn: "idPurchase",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StockMovements_Article_ArticleID",
                table: "StockMovements",
                column: "ArticleID",
                principalTable: "Article",
                principalColumn: "idArticle",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
