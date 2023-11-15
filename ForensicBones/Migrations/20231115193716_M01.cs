using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventariosCranio",
                columns: table => new
                {
                    IdInventarioEsqueleto = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frontal = table.Column<int>(type: "int", nullable: false),
                    Ocipital = table.Column<int>(type: "int", nullable: false),
                    Esfenoide = table.Column<int>(type: "int", nullable: false),
                    Maxilar = table.Column<int>(type: "int", nullable: false),
                    Vomer = table.Column<int>(type: "int", nullable: false),
                    ParietalEsq = table.Column<int>(type: "int", nullable: false),
                    TemporalEsq = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalEsq = table.Column<int>(type: "int", nullable: false),
                    EtmoideEsq = table.Column<int>(type: "int", nullable: false),
                    LacrimalEsq = table.Column<int>(type: "int", nullable: false),
                    NasalEsq = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoEsq = table.Column<int>(type: "int", nullable: false),
                    ParietalDir = table.Column<int>(type: "int", nullable: false),
                    TemporalDir = table.Column<int>(type: "int", nullable: false),
                    ConchaNasalDir = table.Column<int>(type: "int", nullable: false),
                    EtmoideDir = table.Column<int>(type: "int", nullable: false),
                    LacrimalDir = table.Column<int>(type: "int", nullable: false),
                    ZigomaticoDir = table.Column<int>(type: "int", nullable: false),
                    Hioide = table.Column<int>(type: "int", nullable: false),
                    CartilagemTireoide = table.Column<int>(type: "int", nullable: false),
                    Mandibula = table.Column<int>(type: "int", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosCranio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventariosEsqueleto",
                columns: table => new
                {
                    IdRelatorio = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventariosEsqueleto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarcadoresCranios",
                columns: table => new
                {
                    IdInventarioCranio = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CristaNucal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ProcessoMastoide = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EminenciaMentoniana = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SupraOrbital = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AreaGlabela = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ResultadoSexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcadoresCranios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventariosCranio");

            migrationBuilder.DropTable(
                name: "InventariosEsqueleto");

            migrationBuilder.DropTable(
                name: "MarcadoresCranios");

            migrationBuilder.DropTable(
                name: "Relatorios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
