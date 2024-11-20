using API_Gestao_Facil.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Gestao_Facil.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Servidor> Servidores { get; set; }
    }
}
