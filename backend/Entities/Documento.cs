using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Documento : BaseEntity
    {
        public string nome { get; set; }
        public string nome_arquivo { get; set; }
        public int tamanho_bytes { get; set; }
        public Documento()
        {
        }
    }
}
