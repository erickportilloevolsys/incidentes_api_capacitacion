using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadosIncidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosIncidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImpactosIncidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImpactosIncidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaResolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdImpacto = table.Column<int>(type: "int", nullable: false),
                    IdPrioridad = table.Column<int>(type: "int", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrioridadesIncidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrioridadesIncidentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposIncidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposIncidentes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "EstadosIncidentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "SOLICITADO" },
                    { 2, "EN PROCESO" },
                    { 3, "RESUELTO" },
                    { 4, "CERRADO" },
                    { 5, "CANCELADO" }
                });

            migrationBuilder.InsertData(
                table: "ImpactosIncidentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "UN USUARIO" },
                    { 2, "VARIOS USUARIOS" },
                    { 3, "TODA LA INSTITUCIÓN" }
                });

            migrationBuilder.InsertData(
                table: "PrioridadesIncidentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "NO PUEDE ESPERAR" },
                    { 2, "PUEDE ESPERAR UNOS MINUTOS" },
                    { 3, "PUEDE ESPERAR HORAS" },
                    { 4, "PUEDE ESPERAR DIAS" }
                });

            migrationBuilder.InsertData(
                table: "TiposIncidentes",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1, "ERROR DE SISTEMA" },
                    { 2, "ERROR DE USUARIO" },
                    { 3, "CONSULTA SOBRE FUNCIONALIDAD DEL SISTEMA" },
                    { 4, "SOLICITUD DE INFORMACIÓN" },
                    { 5, "NUEVO REQUERIMIENTO" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadosIncidentes");

            migrationBuilder.DropTable(
                name: "ImpactosIncidentes");

            migrationBuilder.DropTable(
                name: "Incidentes");

            migrationBuilder.DropTable(
                name: "PrioridadesIncidentes");

            migrationBuilder.DropTable(
                name: "TiposIncidentes");
        }
    }
}
