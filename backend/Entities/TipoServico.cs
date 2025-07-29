using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class TipoServico : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public TipoServico()
        {
            Servicos = new List<Servico>();
        }
    }
}
