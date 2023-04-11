using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Helpers.Interfaces;
using HubDigital.Dominio.Model.Request;
using HubDigital.Dominio.Model.Response;
using HubDigital.Dominio.Repositorio;
using HubDigital.Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IJwtUtils _jwtUtils;


        public UsuarioService(IUsuarioRepositorio usuarioRepositorio, IJwtUtils jwtUtils)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _jwtUtils = jwtUtils;

        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var usuario = await _usuarioRepositorio.Obter(model.Login!, model.Senha!);

            if (usuario == null) return null;

            var token = _jwtUtils.GerarTokenJwt(usuario);

            return new AuthenticateResponse(usuario, token);

        }

        public async Task<Usuario> GetUsuario(int id)
        {
            return await _usuarioRepositorio.Obter(id);
        }

        public async Task<Usuario> GetUsuarioByGuid(Guid guid)
        {
            return await _usuarioRepositorio.ObterByGuid(guid);
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await _usuarioRepositorio.ObterTodos();

        }
    }
}
