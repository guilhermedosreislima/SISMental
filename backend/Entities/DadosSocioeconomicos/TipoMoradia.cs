using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosSocioeconomicos
{
    public class TipoMoradia : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public TipoMoradia()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
