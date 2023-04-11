using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos.Interfaces
{
    public interface ILoginService
    {
        Task EfetuarLogin(string username, string senha);

        Task EfetuarLogout();
    }
}
