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
    public class UsuarioService : Service, IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IJwtUtils _jwtUtils;


        public UsuarioService(
            IUsuarioRepositorio usuarioRepositorio, 
            IJwtUtils jwtUtils,
            IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _jwtUtils = jwtUtils;
        }

        public async Task<Usuario> AtualizarUsuario(PutAtualizarCadastroRequest model)
        {
            var usuario = await _usuarioRepositorio.Obter(model.IdUsuario);

            if (usuario == null)
                throw new Exception("Nenhum usuário encontrado com os dados informados!");


            usuario.Nome = model.Nome;
            usuario.Login = model.Login;
            usuario.Senha = model.Senha;
            usuario.Email = model.Email;
            usuario.DataNascimento = model.DataNascimento;

            await SaveChangesAsync();

            return usuario;

        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var usuario = await _usuarioRepositorio.Obter(model.Login!, model.Senha!);

            if (usuario == null) return null;

            var token = _jwtUtils.GerarTokenJwt(usuario);

            return new AuthenticateResponse(usuario, token);

        }

        public Task<Usuario> CadastroUsuario(PostCadastroRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> CriarNovaConta(PostNovaContaRequest model)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            return await _usuarioRepositorio.Obter(id);
        }

        public async Task<Usuario> GetUsuarioByGuid(Guid guid)
        {
            return await _usuarioRepositorio.ObterByGuid(guid);
        }

        public async Task<List<GetUsuarioResponseModel>> GetUsuarios()
        {
            var listaEntidade =  await _usuarioRepositorio.ObterTodos();
            List<GetUsuarioResponseModel> usuariosModel = new List<GetUsuarioResponseModel>();

            foreach (var entidade in listaEntidade)
            {
                usuariosModel.Add(GetUsuarioResponseModel.CriarComUsuario(entidade));
            }

            return usuariosModel;
        }
    }
}
