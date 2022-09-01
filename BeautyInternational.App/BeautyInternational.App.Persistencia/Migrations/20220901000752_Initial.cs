using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyInternational.App.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Logueos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logueos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    servicioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Citas_Servicios_servicioid",
                        column: x => x.servicioid,
                        principalTable: "Servicios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registroUnico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    citaid = table.Column<int>(type: "int", nullable: true),
                    historiaid = table.Column<int>(type: "int", nullable: true),
                    ClsProfesional_nivelEstudio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClsProfesional_citaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Citas_citaid",
                        column: x => x.citaid,
                        principalTable: "Citas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Citas_ClsProfesional_citaid",
                        column: x => x.ClsProfesional_citaid,
                        principalTable: "Citas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Historias_historiaid",
                        column: x => x.historiaid,
                        principalTable: "Historias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_servicioid",
                table: "Citas",
                column: "servicioid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_citaid",
                table: "Personas",
                column: "citaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ClsProfesional_citaid",
                table: "Personas",
                column: "ClsProfesional_citaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_historiaid",
                table: "Personas",
                column: "historiaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logueos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
