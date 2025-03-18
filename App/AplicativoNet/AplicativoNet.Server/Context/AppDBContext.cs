using AplicativoNet.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicativoNet.Server.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() { }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Triagem> Triagems { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
    }
}
