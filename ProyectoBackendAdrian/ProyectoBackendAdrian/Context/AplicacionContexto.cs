using Microsoft.EntityFrameworkCore;
using ProyectoBackendAdrian.Models;

namespace WebApplication3.Contexto
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto(DbContextOptions<AplicacionContexto> options):base(options) { }
        public DbSet<Aviones> aviones { get; set; }
        public DbSet<Hangar> hangares { get; set; }
        public DbSet<Piloto> piloto { get; set; }
    }
}
