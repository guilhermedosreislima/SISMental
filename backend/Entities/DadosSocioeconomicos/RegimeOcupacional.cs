using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosSocioeconomicos
{
    public class RegimeOcupacional : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public RegimeOcupacional()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
