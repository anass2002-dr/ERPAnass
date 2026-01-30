using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddUomMultiplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Multiplier",
                table: "UnitOfMeasures",
                type: "decimal(65,30)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UomidUom",
                table: "PurchaseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idUom",
                table: "PurchaseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_UomidUom",
                table: "PurchaseDetails",
                column: "UomidUom");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_UnitOfMeasures_UomidUom",
                table: "PurchaseDetails",
                column: "UomidUom",
                principalTable: "UnitOfMeasures",
                principalColumn: "idUom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_UnitOfMeasures_UomidUom",
                table: "PurchaseDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseDetails_UomidUom",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "Multiplier",
                table: "UnitOfMeasures");

            migrationBuilder.DropColumn(
                name: "UomidUom",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "idUom",
                table: "PurchaseDetails");
        }
    }
}
