using HubDigital.Api.Authorization;
using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Model.Request;
using HubDigital.Dominio.Servicos;
using HubDigital.Dominio.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HubDigital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public AuthenticationController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest model)
        {

            var response = await _usuarioService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Usuário ou senha incorretos" });

            return Ok(response);
        }
    }
}
