using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class PurchaseRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PurchaseDetails");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Purchases",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "Purchases",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "idAccount",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idEmployee",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idInvoice",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idWarehouse",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PurchaseDetails",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "PurchaseDetails",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "PurchaseDetails",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PurchaseDetails",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idTaxConfig",
                table: "PurchaseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TaxConfigurations",
                columns: table => new
                {
                    idTaxConfig = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaxRate = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsAcitve = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxConfigurations", x => x.idTaxConfig);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_idAccount",
                table: "Purchases",
                column: "idAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_idEmployee",
                table: "Purchases",
                column: "idEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_idInvoice",
                table: "Purchases",
                column: "idInvoice");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_idWarehouse",
                table: "Purchases",
                column: "idWarehouse");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_idTaxConfig",
                table: "PurchaseDetails",
                column: "idTaxConfig");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Purchases_idPurchase",
                table: "PurchaseDetails",
                column: "idPurchase",
                principalTable: "Purchases",
                principalColumn: "idPurchase",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_TaxConfigurations_idTaxConfig",
                table: "PurchaseDetails",
                column: "idTaxConfig",
                principalTable: "TaxConfigurations",
                principalColumn: "idTaxConfig",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Accounts_idAccount",
                table: "Purchases",
                column: "idAccount",
                principalTable: "Accounts",
                principalColumn: "idAccount",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Employees_idEmployee",
                table: "Purchases",
                column: "idEmployee",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Invoices_idInvoice",
                table: "Purchases",
                column: "idInvoice",
                principalTable: "Invoices",
                principalColumn: "idInvoice",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Warehouses_idWarehouse",
                table: "Purchases",
                column: "idWarehouse",
                principalTable: "Warehouses",
                principalColumn: "idWarehouse",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Purchases_idPurchase",
                table: "PurchaseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_TaxConfigurations_idTaxConfig",
                table: "PurchaseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Accounts_idAccount",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Employees_idEmployee",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Invoices_idInvoice",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Warehouses_idWarehouse",
                table: "Purchases");

            migrationBuilder.DropTable(
                name: "TaxConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_idAccount",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_idEmployee",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_idInvoice",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_idWarehouse",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseDetails_idTaxConfig",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "idAccount",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "idEmployee",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "idInvoice",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "idWarehouse",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "idTaxConfig",
                table: "PurchaseDetails");

            migrationBuilder.RenameColumn(
                name: "idPurchase",
                table: "Purchases",
                newName: "IdPurchase");

            migrationBuilder.RenameColumn(
                name: "idPurchase",
                table: "PurchaseDetails",
                newName: "IdPurchase");

            migrationBuilder.RenameColumn(
                name: "idPurchaseDetails",
                table: "PurchaseDetails",
                newName: "IdPurchaseDetails");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseDetails_idPurchase",
                table: "PurchaseDetails",
                newName: "IX_PurchaseDetails_IdPurchase");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Purchases",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Purchases",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Purchases",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PurchaseDetails",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails",
                column: "IdPurchase",
                principalTable: "Purchases",
                principalColumn: "IdPurchase",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
