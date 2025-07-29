using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities.DadosClinicos
{
    public class SituacaoProntuario : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public SituacaoProntuario()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
        }
    }
}
