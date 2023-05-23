using HubDigital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Model.Response
{
    public class GetUsuarioResponseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public static GetUsuarioResponseModel CriarComUsuario(Usuario usuario) => new GetUsuarioResponseModel()
        {
            Nome = usuario.Nome,
            Email = usuario.Email,
        };


    }
}
