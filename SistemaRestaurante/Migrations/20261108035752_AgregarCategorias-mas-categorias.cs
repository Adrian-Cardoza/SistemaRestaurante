using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SistemaRestaurante.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCategoriasmascategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nombre",
                value: "Entradas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nombre",
                value: "Desayunos");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 3,
                column: "Nombre",
                value: "Platos fuertes");

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "ID", "Nombre" },
                values: new object[,]
                {
                    { 4, "Postres" },
                    { 5, "Bebidas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nombre",
                value: "Bebidas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nombre",
                value: "Platos fuertes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "ID",
                keyValue: 3,
                column: "Nombre",
                value: "Postres");
        }
    }
}
