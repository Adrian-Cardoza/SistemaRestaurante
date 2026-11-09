using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaRestaurante.Migrations
{
    /// <inheritdoc />
    public partial class cambioEnFacturaYPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Productos_ProductosID",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Facturas_FacturaId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_FacturaId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_ProductosID",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "FacturaId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ProductosID",
                table: "Facturas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacturaId",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductosID",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_FacturaId",
                table: "Pedidos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ProductosID",
                table: "Facturas",
                column: "ProductosID");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Productos_ProductosID",
                table: "Facturas",
                column: "ProductosID",
                principalTable: "Productos",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Facturas_FacturaId",
                table: "Pedidos",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id");
        }
    }
}
