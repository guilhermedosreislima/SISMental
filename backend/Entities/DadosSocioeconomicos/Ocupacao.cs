using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosSocioeconomicos
{
    public class Ocupacao : BaseEntity
    {
        public string codigo { get; set; }
        public string descricao { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public Ocupacao()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
