using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class cityToSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CityID",
                table: "Supplier",
                column: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_City_CityID",
                table: "Supplier",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_City_CityID",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_CityID",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Supplier");
        }
    }
}
