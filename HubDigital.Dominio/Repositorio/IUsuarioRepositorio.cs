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
        Task<List<Usuario>> ObterTodos();
        Task<Usuario> Obter(int id);
        Task<Usuario> ObterByGuid(Guid guid);
        Task<Usuario> Obter(string login, string senha);

    }
}
