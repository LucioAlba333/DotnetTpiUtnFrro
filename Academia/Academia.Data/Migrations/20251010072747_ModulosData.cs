using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Academia.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModulosData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 3, "Usuarios" },
                    { 4, "Personas" },
                    { 5, "Materias" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
