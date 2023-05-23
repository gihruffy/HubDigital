using HubDigital.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Infra.Database.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Guid).IsRequired();

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Login).IsRequired();
            builder.Property(x => x.Senha).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Permissao).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired().HasColumnName("");
            builder.Property(x => x.Permissao).IsRequired();
        }
    }
}
