using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Problematica.Migrations
{
    /// <inheritdoc />
    public partial class unomu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PuestoId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDelPuesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SueldoBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PuestoId",
                table: "Empleados",
                column: "PuestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Puestos_PuestoId",
                table: "Empleados",
                column: "PuestoId",
                principalTable: "Puestos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Puestos_PuestoId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PuestoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PuestoId",
                table: "Empleados");
        }
    }
}
