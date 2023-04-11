using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Model.Request;
using HubDigital.Dominio.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos.Interfaces
{
    public interface IUsuarioService
    {

        Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        Task<Usuario> GetUsuario(int id);
        Task<List<Usuario>> GetUsuarios();
        Task<Usuario> GetUsuarioByGuid(Guid guid);

    }
}
