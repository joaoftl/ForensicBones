using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<InventarioEsqueleto> Inventarios { get; set; }
        public DbSet<InventarioCranio> InventariosCranio { get; set; }

        public DbSet<MarcadoresCranio> MarcadoresCranios { get; set; }
    }
}
