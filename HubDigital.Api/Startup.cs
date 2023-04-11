using HubDigital.Api.Middleware;
using HubDigital.Dominio.Helpers;
using HubDigital.Dominio.Helpers.Interfaces;
using HubDigital.Dominio.Repositorio;
using HubDigital.Dominio.Servicos;
using HubDigital.Dominio.Servicos.Interfaces;
using HubDigital.Infra.Database.Contexto;
using HubDigital.Infra.Database.Repositorio;
using Humanizer.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

namespace HubDigital.Api
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HubDigital API V1");
            });


            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseMiddleware<HubDigitalExceptionHandlerMiddleware>();

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

            app.MapControllers();

            app.Run();

        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddControllers();

            var connectionString = _configuration.GetConnectionString("SQLite") ?? "Data Source=hubdigital";
            services.AddDbContext<HubDigitalContext>(x =>
                x.UseSqlite(connectionString));

            /*
            services.AddDbContext<HubDigitalContext>();
            services.AddSqlite<HubDigitalContext>();
            */

            services.Configure<AppSettings>(_configuration.GetSection("AppSettings"));


            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "HubDigital API",
                    Description = "APIS DO HUBDIGITAL",
                    Version = "v1"
                });

            });


            //Geral
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Services
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IJwtUtils, JwtUtils>();


            //Repositorio
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

        }

    }
}
