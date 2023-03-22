using HubDigital.Dominio.Repositorio;
using HubDigital.Infra.Database.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Infra.Database.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HubDigitalContext _context;

        public UnitOfWork(HubDigitalContext context)
        {
            _context = context;
        }


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
