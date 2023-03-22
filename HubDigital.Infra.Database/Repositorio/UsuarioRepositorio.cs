using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Repositorio;
using HubDigital.Infra.Database.Contexto;
using Microsoft.EntityFrameworkCore;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Infra.Database.Repositorio
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(HubDigitalContext context) : base(context) { }

        public async Task<Usuario> Obter(int id)
        {
            return await NoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario> ObterByGuid(Guid guid)
        {
            return await NoTracking().FirstOrDefaultAsync(x => x.Guid == guid);
        }
    }
}
