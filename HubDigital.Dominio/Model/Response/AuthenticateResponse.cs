using HubDigital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Model.Response
{
    public  class AuthenticateResponse
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(Usuario usuario, string token)
        {
            Id = usuario.Id;
            Nome = usuario.Nome;
            Email = usuario.Email;
            Login = usuario.Login;
            Token = token;
        }

    }
}
