using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class addTotalPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPayment",
                table: "Purchases",
                type: "decimal(65,30)",
                nullable: true,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPayment",
                table: "Purchases");
        }
    }
}
