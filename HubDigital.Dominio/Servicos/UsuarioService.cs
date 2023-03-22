using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Repositorio;
using HubDigital.Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio; 
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public async Task<Usuario> GetUsuario(int id)
        {
            return await _usuarioRepositorio.Obter(id);
        }

        public async Task<Usuario> GetUsuarioByGuid(Guid guid)
        {
            return await _usuarioRepositorio.ObterByGuid(guid);
        }
    }
}
