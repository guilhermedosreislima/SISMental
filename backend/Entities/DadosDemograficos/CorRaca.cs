using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosDemograficos
{
    public class CorRaca : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public CorRaca()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
