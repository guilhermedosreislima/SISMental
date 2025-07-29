using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosDemograficos
{
    public class Sexo : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public Sexo()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
