using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class Add_navigation_properties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoIncidente",
                table: "Incidentes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_IdEstado",
                table: "Incidentes",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_IdImpacto",
                table: "Incidentes",
                column: "IdImpacto");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_IdPrioridad",
                table: "Incidentes",
                column: "IdPrioridad");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_IdTipoIncidente",
                table: "Incidentes",
                column: "IdTipoIncidente");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_EstadosIncidentes_IdEstado",
                table: "Incidentes",
                column: "IdEstado",
                principalTable: "EstadosIncidentes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_ImpactosIncidentes_IdImpacto",
                table: "Incidentes",
                column: "IdImpacto",
                principalTable: "ImpactosIncidentes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_PrioridadesIncidentes_IdPrioridad",
                table: "Incidentes",
                column: "IdPrioridad",
                principalTable: "PrioridadesIncidentes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidentes_TiposIncidentes_IdTipoIncidente",
                table: "Incidentes",
                column: "IdTipoIncidente",
                principalTable: "TiposIncidentes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_EstadosIncidentes_IdEstado",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_ImpactosIncidentes_IdImpacto",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_PrioridadesIncidentes_IdPrioridad",
                table: "Incidentes");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidentes_TiposIncidentes_IdTipoIncidente",
                table: "Incidentes");

            migrationBuilder.DropIndex(
                name: "IX_Incidentes_IdEstado",
                table: "Incidentes");

            migrationBuilder.DropIndex(
                name: "IX_Incidentes_IdImpacto",
                table: "Incidentes");

            migrationBuilder.DropIndex(
                name: "IX_Incidentes_IdPrioridad",
                table: "Incidentes");

            migrationBuilder.DropIndex(
                name: "IX_Incidentes_IdTipoIncidente",
                table: "Incidentes");

            migrationBuilder.DropColumn(
                name: "IdTipoIncidente",
                table: "Incidentes");
        }
    }
}
