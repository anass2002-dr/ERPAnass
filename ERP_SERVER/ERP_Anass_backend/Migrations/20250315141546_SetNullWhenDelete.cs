using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class SetNullWhenDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

         


            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Brand_BrandID",
                table: "Article",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Familly_FamilyID",
                table: "Article",
                column: "FamilyID",
                principalTable: "Familly",
                principalColumn: "idFamilly",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Familly_idFamilly",
                table: "Brand",
                column: "idFamilly",
                principalTable: "Familly",
                principalColumn: "idFamilly",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_City_CityID",
                table: "Employees",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Country_CountryId",
                table: "Employees",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Works_WorksID",
                table: "Employees",
                column: "WorksID",
                principalTable: "Works",
                principalColumn: "WorkstID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Modules_IdModule",
                table: "Permissions",
                column: "IdModule",
                principalTable: "Modules",
                principalColumn: "IdModule",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Article_idArticle",
                table: "PurchaseDetails",
                column: "idArticle",
                principalTable: "Article",
                principalColumn: "idArticle",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails",
                column: "IdPurchase",
                principalTable: "Purchases",
                principalColumn: "IdPurchase",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Currency_IdCurrency",
                table: "Purchases",
                column: "IdCurrency",
                principalTable: "Currency",
                principalColumn: "IdCurrency",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Supplier_idSupplier",
                table: "Purchases",
                column: "idSupplier",
                principalTable: "Supplier",
                principalColumn: "idSupplier",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Country_CountryId",
                table: "Supplier",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Departments_DepartmentID",
                table: "Works",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Brand_BrandID",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Familly_FamilyID",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Familly_idFamilly",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_City_CityID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Country_CountryId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Works_WorksID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Modules_IdModule",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Article_idArticle",
                table: "PurchaseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Currency_IdCurrency",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Supplier_idSupplier",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Supplier_Country_CountryId",
                table: "Supplier");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Departments_DepartmentID",
                table: "Works");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Brand_BrandID",
                table: "Article",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Familly_FamilyID",
                table: "Article",
                column: "FamilyID",
                principalTable: "Familly",
                principalColumn: "idFamilly");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Familly_idFamilly",
                table: "Brand",
                column: "idFamilly",
                principalTable: "Familly",
                principalColumn: "idFamilly");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_City_CityID",
                table: "Employees",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Country_CountryId",
                table: "Employees",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Works_WorksID",
                table: "Employees",
                column: "WorksID",
                principalTable: "Works",
                principalColumn: "WorkstID");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Modules_IdModule",
                table: "Permissions",
                column: "IdModule",
                principalTable: "Modules",
                principalColumn: "IdModule");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Article_idArticle",
                table: "PurchaseDetails",
                column: "idArticle",
                principalTable: "Article",
                principalColumn: "idArticle");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_Purchases_IdPurchase",
                table: "PurchaseDetails",
                column: "IdPurchase",
                principalTable: "Purchases",
                principalColumn: "IdPurchase");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Currency_IdCurrency",
                table: "Purchases",
                column: "IdCurrency",
                principalTable: "Currency",
                principalColumn: "IdCurrency");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Supplier_idSupplier",
                table: "Purchases",
                column: "idSupplier",
                principalTable: "Supplier",
                principalColumn: "idSupplier");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplier_Country_CountryId",
                table: "Supplier",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Departments_DepartmentID",
                table: "Works",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }
    }
}
