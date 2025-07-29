using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class DigitadorServico : BaseEntity
    {
        public Guid id_usuario { get; set; }
        public Usuario Usuario { get; set; }
        public Guid id_servico { get; set; }
        public Servico Servico { get; set; }

        public DigitadorServico()
        {
        }
    }
}
