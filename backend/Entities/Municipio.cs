using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Municipio : BaseEntity
    {
        public string nome { get; set; }
        public Guid id_regional { get; set; }
        public virtual Regional Regional { get; set; }
        public long codigo_ibge { get; set; }

        public virtual ICollection<Servico> Servicos { get; set; }
        public Municipio()
        {
            Servicos = new List<Servico>();
        }
    }
}
