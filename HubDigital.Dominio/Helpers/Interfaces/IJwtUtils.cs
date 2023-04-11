using HubDigital.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Helpers.Interfaces
{
    public interface IJwtUtils
    {
        public string GerarTokenJwt(Usuario usuario);
        public int? ValidarTokenJwt(string? token);

    }
}
