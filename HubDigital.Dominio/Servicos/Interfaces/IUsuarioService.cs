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
        Task<List<GetUsuarioResponseModel>> GetUsuarios();
        Task<Usuario> GetUsuario(int id);
        Task<Usuario> GetUsuarioByGuid(Guid guid);
        Task<Usuario> CadastroUsuario(PostCadastroRequest model);
        Task<Usuario> CriarNovaConta(PostNovaContaRequest model);
        Task<Usuario> AtualizarUsuario(PutAtualizarCadastroRequest model);
        Task<Usuario> DeletarUsuario(int id);
    }
}
