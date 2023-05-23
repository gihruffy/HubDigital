using HubDigital.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Model.Request
{
    public class PostCadastroRequest
    {
        public string NomeStartup { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public AreaAtuacaoEnum AreaAtuacao { get; set; }
        public int EmpresaVinculada { get; set; }
        public string Observacoes { get; set; }
        public List<string> Experiencias { get; set; }
        public List<string> Educacao { get; set; }
        public bool DisponivelMentorias { get; set; }

    }

}
