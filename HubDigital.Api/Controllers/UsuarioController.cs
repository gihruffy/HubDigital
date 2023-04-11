using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
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

      /*  [HttpGet]
        public async Task<Usuario> GetUsuario(int id)
        {
            return await _usuarioService.GetUsuario(id);
        }*/

        [HttpGet]
        public async Task<List<Usuario>> GetTodosUsuarios()
        {
            return await _usuarioService.GetUsuarios();
        }


    }
}
