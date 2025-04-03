using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTecnica.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ope");

            migrationBuilder.CreateTable(
                name: "Prueba",
                schema: "Ope",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDocumento = table.Column<long>(type: "bigint", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoCivil = table.Column<long>(type: "bigint", nullable: true),
                    FechaAdicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdUsuarioAdiciono = table.Column<long>(type: "bigint", nullable: true),
                    IdUsuarioUltimaActualizacion = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prueba", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "ParametroGeneral",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "Nombre" },
                values: new object[,]
                {
                    { 2L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "Tipo Doucmento" },
                    { 3L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1L, null, "Estado Civil" }
                });

            migrationBuilder.InsertData(
                schema: "Par",
                table: "ParametroDetallado",
                columns: new[] { "Id", "FechaAdicion", "FechaUltimaActualizacion", "IdParametroGeneral", "IdUsuarioAdiciono", "IdUsuarioUltimaActualizacion", "Nombre" },
                values: new object[,]
                {
                    { 3L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, 1L, null, "CC" },
                    { 4L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, 1L, null, "Nit" },
                    { 5L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2L, 1L, null, "Ce" },
                    { 6L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, 1L, null, "Soltero" },
                    { 7L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, 1L, null, "Casado" },
                    { 8L, new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3L, 1L, null, "Divorciado" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prueba_TipoDocumento",
                schema: "Ope",
                table: "Prueba",
                column: "TipoDocumento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prueba",
                schema: "Ope");

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroDetallado",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroGeneral",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Par",
                table: "ParametroGeneral",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
