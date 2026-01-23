using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class IntegrationAccountModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
             * Content commented out because database is already up to date.
             * This migration just updates the history table.
             */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Accounts_idIncomeAccount",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Accounts_idInventoryAccount",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Accounts_idControlAccount",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Accounts_idExpenseAccount",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Accounts_idCashAccount",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Accounts_idControlAccount",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Supplier_idControlAccount",
                table: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_Payments_idCashAccount",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_idExpenseAccount",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customer_idControlAccount",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Article_idIncomeAccount",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_idInventoryAccount",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "idControlAccount",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "idCashAccount",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "idExpenseAccount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "idControlAccount",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "idIncomeAccount",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "idInventoryAccount",
                table: "Article");
        }
    }
}
