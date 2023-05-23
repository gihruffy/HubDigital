using HubDigital.Dominio.Entidades;
using HubDigital.Infra.Database.Configurations;
using HubDigital.Infra.Database.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HubDigital.Infra.Database.Contexto
{
    public class HubDigitalContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }



        public HubDigitalContext(DbContextOptions<HubDigitalContext> options) : base(options)
        {
           // Database.Migrate();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

    }
}
