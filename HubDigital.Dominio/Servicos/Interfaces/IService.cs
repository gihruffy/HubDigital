﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Servicos.Interfaces
{
    public interface IService
    {
        Task<bool> SaveChangesAsync();
    }
}
