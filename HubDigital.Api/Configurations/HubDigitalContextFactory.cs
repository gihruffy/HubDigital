using HubDigital.Infra.Database.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HubDigital.Api.Configurations
{
    public class HubDigitalContextFactory : IDesignTimeDbContextFactory<HubDigitalContext>
    {
        public HubDigitalContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<HubDigitalContext>()
                .UseSqlite(config.GetConnectionString("SQLite"), x => x.MigrationsAssembly("HubDigital.Infra.Database"));

            return new HubDigitalContext(builder.Options);
        }
    }
}
