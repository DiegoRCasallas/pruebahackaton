using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackaton.App.Persistencia.Migrations
{
    public partial class MigraInicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    publico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    privado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sin_animo_de_lucro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    no_gubernamental = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    juridicos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    viveres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comida_preparada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empleo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alojamiento_temporal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alojamiennto_permanente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    otros = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
