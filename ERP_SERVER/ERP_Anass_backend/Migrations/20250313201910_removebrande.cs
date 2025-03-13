using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class removebrande : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Works",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Users",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Permissions",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Modules",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Familly",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Employees",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Departments",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "City",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAcitve",
                table: "Article",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Familly");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "City");

            migrationBuilder.DropColumn(
                name: "IsAcitve",
                table: "Article");
        }
    }
}
