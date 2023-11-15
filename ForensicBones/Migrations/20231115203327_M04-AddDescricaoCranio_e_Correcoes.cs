using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones.Migrations
{
    public partial class M04AddDescricaoCranio_e_Correcoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdInventarioCranio",
                table: "InventariosEsqueleto",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<int>(
                name: "IdDescricaoCranio",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<int>(
                name: "IdMarcadoresCranio",
                table: "InventariosCranio",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.CreateTable(
                name: "DescricoesCranios",
                columns: table => new
                {
                    IdInventarioCranio = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frontal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocipital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Esfenoide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maxilar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vomer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NasalEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoEsq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParietalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConchaNasalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtmoideDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LacrimalDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZigomaticoDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hioide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartilagemTireoide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mandibula = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescricoesCranios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescricoesCranios");

            migrationBuilder.DropColumn(
                name: "IdInventarioCranio",
                table: "InventariosEsqueleto");

            migrationBuilder.DropColumn(
                name: "IdDescricaoCranio",
                table: "InventariosCranio");

            migrationBuilder.DropColumn(
                name: "IdMarcadoresCranio",
                table: "InventariosCranio");
        }
    }
}
