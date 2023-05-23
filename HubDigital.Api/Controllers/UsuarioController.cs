using HubDigital.Dominio.Model.Request;
using HubDigital.Dominio.Model.Response;
using HubDigital.Dominio.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HubDigital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("todos")]
        public async Task<List<GetUsuarioResponseModel>> GetTodosUsuarios()
        {
            return await _usuarioService.GetUsuarios();
        }

        [HttpGet]
        [Route("usuario")]
        public async Task GetUsuario(int idUsuario)
        {
            await _usuarioService.GetUsuario(idUsuario);
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task PostUsuario([FromBody] PostCadastroRequest model )
        {
            await _usuarioService.CadastroUsuario(model);
        }

        [HttpPost]
        [Route("nova-conta")]
        public async Task SalvarUsuario([FromBody] PostNovaContaRequest model)
        {
            await _usuarioService.CriarNovaConta(model);
        }

        [HttpPut]
        [Route("atualizar-cadastro")]
        public async Task AtualziarCadastro([FromBody] PutAtualizarCadastroRequest model)
        {
            await _usuarioService.AtualizarUsuario(model);
        }

        [HttpDelete]
        [Route("deletar-usuario")]
        public async Task DeletarUsuarios(int idUsuario)
        {
            await _usuarioService.DeletarUsuario(idUsuario);
        }
    }
}
