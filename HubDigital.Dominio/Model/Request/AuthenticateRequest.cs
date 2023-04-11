﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Model.Request
{
    public class AuthenticateRequest
    {
        [Required]
        public string? Login { get; set; }

        [Required]
        public string? Senha { get; set; }
    }
}
