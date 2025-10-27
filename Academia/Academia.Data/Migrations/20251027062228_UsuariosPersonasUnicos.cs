using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Academia.Data.Migrations
{
    /// <inheritdoc />
    public partial class UsuariosPersonasUnicos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Comisiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnioEspecialidad = table.Column<int>(type: "int", nullable: false),
                    IdPlan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comisiones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comisiones_Planes_IdPlan",
                        column: x => x.IdPlan,
                        principalTable: "Planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnioCalendario = table.Column<int>(type: "int", nullable: false),
                    Cupo = table.Column<int>(type: "int", nullable: false),
                    IdMateria = table.Column<int>(type: "int", nullable: false),
                    IdComision = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Comisiones_IdComision",
                        column: x => x.IdComision,
                        principalTable: "Comisiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cursos_Materias_IdMateria",
                        column: x => x.IdMateria,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocenteCursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<int>(type: "int", nullable: false),
                    IdCurso = table.Column<int>(type: "int", nullable: false),
                    IdDocente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocenteCursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocenteCursos_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocenteCursos_Personas_IdDocente",
                        column: x => x.IdDocente,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    IdCurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Personas_IdAlumno",
                        column: x => x.IdAlumno,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 6, "Comisiones" },
                    { 7, "Cursos" },
                    { 8, "DocentesCursos" },
                    { 9, "Inscripciones" }
                });

            migrationBuilder.UpdateData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Legajo",
                value: 1000);

            migrationBuilder.CreateIndex(
                name: "IX_Comisiones_IdPlan",
                table: "Comisiones",
                column: "IdPlan");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_IdComision",
                table: "Cursos",
                column: "IdComision");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_IdMateria",
                table: "Cursos",
                column: "IdMateria");

            migrationBuilder.CreateIndex(
                name: "IX_DocenteCursos_IdCurso",
                table: "DocenteCursos",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_DocenteCursos_IdDocente",
                table: "DocenteCursos",
                column: "IdDocente");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_IdAlumno",
                table: "Inscripciones",
                column: "IdAlumno");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_IdCurso",
                table: "Inscripciones",
                column: "IdCurso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocenteCursos");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Comisiones");

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modulos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ModuloUsuarios",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Legajo",
                value: 1);

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
    }
}
