using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaRestaurante.Migrations
{
    /// <inheritdoc />
    public partial class DatoSemillaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Correo", "DUI", "Nombre" },
                values: new object[] { 1, "juan.perez@example.com", 12345678, "Juan Perez" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
