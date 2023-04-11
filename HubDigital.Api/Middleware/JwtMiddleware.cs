using HubDigital.Dominio.Helpers.Interfaces;
using HubDigital.Dominio.Servicos.Interfaces;

namespace HubDigital.Api.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IUsuarioService usuarioService, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jwtUtils.ValidarTokenJwt(token);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["Usuario"] = usuarioService.GetUsuario(userId.Value);
            }

            await _next(context);
        }



    }
}
