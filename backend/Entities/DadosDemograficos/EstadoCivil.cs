using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosDemograficos
{
    public class EstadoCivil : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public EstadoCivil()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
