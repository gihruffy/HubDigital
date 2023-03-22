using HubDigital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> Obter(int id);
        Task<Usuario> ObterByGuid(Guid guid);

    }
}
