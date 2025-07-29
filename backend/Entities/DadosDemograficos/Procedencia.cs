using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosDemograficos
{
    public class Procedencia : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public Procedencia()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
