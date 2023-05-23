using HubDigital.Dominio.Repositorio;
using HubDigital.Dominio.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos
{
    public class Service : IService
    {
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> SaveChangesAsync() => _unitOfWork.SaveChangesAsync();

    }
}
