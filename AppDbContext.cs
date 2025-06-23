using System.Data.Entity;

namespace SistemaFuncionarios
{
    public class AppDbContext : DbContext
    {
        public DbSet<Profissional> Profissionais { get; set; }

        public AppDbContext() : base("AppDbContext") { }
    }
}
