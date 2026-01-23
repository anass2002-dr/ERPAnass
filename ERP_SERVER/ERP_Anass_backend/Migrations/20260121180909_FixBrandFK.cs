using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class FixBrandFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Familly_FamillyidFamilly",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_FamillyidFamilly",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "FamillyidFamilly",
                table: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_idFamilly",
                table: "Brand",
                column: "idFamilly");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Familly_idFamilly",
                table: "Brand",
                column: "idFamilly",
                principalTable: "Familly",
                principalColumn: "idFamilly");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Familly_idFamilly",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_idFamilly",
                table: "Brand");

            migrationBuilder.AddColumn<int>(
                name: "FamillyidFamilly",
                table: "Brand",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brand_FamillyidFamilly",
                table: "Brand",
                column: "FamillyidFamilly");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Familly_FamillyidFamilly",
                table: "Brand",
                column: "FamillyidFamilly",
                principalTable: "Familly",
                principalColumn: "idFamilly");
        }
    }
}
