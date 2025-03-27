using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class addTotalPayment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPayment",
                table: "Purchases",
                type: "decimal(65,30)",
                nullable: true);
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
