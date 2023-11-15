using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForensicBones.Migrations
{
    public partial class M03AddTableMarcadoresCranioFixMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarcadoresCranios");
        }
    }
}
