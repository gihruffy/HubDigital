using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Repositorio
{
    public interface IRepository<T, in TPk> : IDisposable
    {
        T Salvar(T entity);
        Task DeletarAsync(TPk identifier);
        Task<bool> ExisteAsync(TPk identifier);
        Task<T> ObterPorIdentificadorAsync(TPk identifier);
        Task<IEnumerable<T>> ObterTodosAsync();
        IQueryable<T> NoTracking();
    }
}
