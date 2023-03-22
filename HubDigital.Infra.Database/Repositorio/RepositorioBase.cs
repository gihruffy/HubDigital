using HubDigital.Dominio.Entidades;
using HubDigital.Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Infra.Database.Repositorio
{
    public class RepositorioBase<T> : IRepository<T, Guid> where T : Entity
    {
        public readonly DbContext Context;
        public readonly DbSet<T> DbSet;

        public RepositorioBase(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public T Salvar(T entity)
        {
            if (entity.IsNew)
                DbSet.Add(entity);
            else
                DbSet.Update(entity);

            return entity;
        }
        public virtual async Task DeletarAsync(Guid identifier)
        {
            var ett = await NoTracking().FirstOrDefaultAsync(x => x.Guid == identifier);

            DbSet.Remove(ett);
        }

        public virtual async Task<bool> ExisteAsync(Guid identifier)
        {
            return await DbSet.AnyAsync(x => x.Guid == identifier);
        }

        public virtual async Task<T> ObterPorIdentificadorAsync(Guid identifier) => await NoTracking().FirstOrDefaultAsync(x => x.Guid == identifier);

        public virtual async Task<IEnumerable<T>> ObterTodosAsync()
        {
            return await NoTracking().ToListAsync();
        }

        public virtual IQueryable<T> NoTracking()
        {
            return DbSet.AsNoTracking();
        }


        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
