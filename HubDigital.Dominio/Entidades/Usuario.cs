using HubDigital.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Entidades
{
    public class Usuario: Entity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; protected set; }
        public TipoPermissao Permissao { get; set; }

        public Usuario(string nome, string login, string senha, string email, DateTime dataNascimento, bool ativo, TipoPermissao permissao, DateTime dataCriacao)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            Email = email;
            DataNascimento = dataNascimento;
            Ativo = ativo;
            Permissao = permissao;
            DataCriacao = dataCriacao;
        }

        public Usuario()
        {

        }

        public static Usuario Criar(int id,
            Guid guid,
            string nome,
            string login,
            string senha,
            string email,
            DateTime dataNascimento,
            TipoPermissao tipoPermissao)
            => new Usuario
            {
                Id = id,
                Guid = guid,
                Nome = nome,
                Login = login,
                Senha = senha,
                Email = email,
                DataNascimento  = dataNascimento,
                Permissao = tipoPermissao,
                DataCriacao = DateTime.Now
            };

        public void Ativar()
        {
            this.Ativo = true;
        }

        public void Desativar()
        {
            this.Ativo = false;
        }
    }
}
