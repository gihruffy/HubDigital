using HubDigital.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Infra.Database.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Usuario>()
                .HasData(
                    Usuario.Criar(1, Guid.NewGuid(), "Giovanni Martinelli", "gmartinelli", "123456", "giovanni.artica@gmail.com", DateTime.Now, Dominio.Enums.TipoPermissao.Admin)
                );
        }
    }
}
