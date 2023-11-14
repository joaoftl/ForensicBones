using Microsoft.EntityFrameworkCore;

namespace ForensicBones.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
