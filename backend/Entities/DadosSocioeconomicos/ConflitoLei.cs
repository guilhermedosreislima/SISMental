using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosSocioeconomicos
{
    public class ConflitoLei : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public ConflitoLei()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
