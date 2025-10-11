using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academia.Data.Migrations
{
    /// <inheritdoc />
    public partial class ArregladoModulosUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ModuloUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModuloUsuarios_UsuarioId",
                table: "ModuloUsuarios",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModuloUsuarios_Usuarios_UsuarioId",
                table: "ModuloUsuarios",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModuloUsuarios_Usuarios_UsuarioId",
                table: "ModuloUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_ModuloUsuarios_UsuarioId",
                table: "ModuloUsuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ModuloUsuarios");
        }
    }
}
