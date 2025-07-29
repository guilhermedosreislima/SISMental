using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        // public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        // public DateTime? DataInativacao { get; set; }
    }
}
