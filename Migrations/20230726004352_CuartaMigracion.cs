using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_majo.Migrations
{
    public partial class CuartaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Roles_IdRoles",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdRoles",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "IdRoles",
                table: "Compras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdRoles",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdRoles",
                table: "Compras",
                column: "IdRoles");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Roles_IdRoles",
                table: "Compras",
                column: "IdRoles",
                principalTable: "Roles",
                principalColumn: "IdRoles",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
