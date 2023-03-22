using HubDigital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(int id);
        Task<Usuario> GetUsuarioByGuid(Guid guid);

    }
}
