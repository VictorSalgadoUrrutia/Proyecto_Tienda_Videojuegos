using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_majo.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Vendedor_IdVendedor",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_IdVendedor",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IdVendedor",
                table: "Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdVendedor",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_IdVendedor",
                table: "Roles",
                column: "IdVendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Vendedor_IdVendedor",
                table: "Roles",
                column: "IdVendedor",
                principalTable: "Vendedor",
                principalColumn: "IdVendedor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
