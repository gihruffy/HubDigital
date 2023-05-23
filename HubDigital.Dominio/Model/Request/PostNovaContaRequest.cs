using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Model.Request
{
    public class PostNovaContaRequest
    {
        public string NomeStartup { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Site { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

    }
}
