using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class PerfilRestricao : BaseEntity
    {
        public Guid PerfilId { get; set; }
        public Guid RestricaoId { get; set; }

        public virtual Perfil Perfil { get; set; }
        //public virtual Restricao Restricao { get; set; }

        // public virtual ICollection<Restricao> Restricoes { get; set; }
        // public virtual ICollection<Perfil> Perfis { get; set; }
        public PerfilRestricao()
        {
            // Restricoes = new List<Restricao>();
            // Perfis = new List<Perfil>();
        }
    }
}
