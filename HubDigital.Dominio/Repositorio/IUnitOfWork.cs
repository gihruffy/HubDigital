using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Repositorio
{
    public interface IUnitOfWork: IDisposable
    {
        bool SaveChanges();
        Task<bool> SaveChangesAsync();
    }
}
