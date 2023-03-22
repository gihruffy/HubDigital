using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubDigital.Dominio.Entidades
{
    public class Entity: EntityBase
    {
        protected Entity() => Guid = Guid.NewGuid();
        public Guid Guid { get; protected set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlterecao { get; set; }
        public bool IsNew => Id == 0;
    }
}
