using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class PatologiaCid10 : BaseEntity
    {
        public string codigo { get; set; }
        public string descricao { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicosDiagnosticoPrimario { get; set; }
        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicosDiagnosticoSecundario { get; set; }
        public virtual ICollection<RegEpidPatCid10> RegEpidPatCid10s { get; set; }
        public PatologiaCid10()
        {
            RegistrosEpidemiologicosDiagnosticoPrimario = new List<RegistroEpidemiologico>();
            RegistrosEpidemiologicosDiagnosticoSecundario = new List<RegistroEpidemiologico>();
            RegEpidPatCid10s = new List<RegEpidPatCid10>();
        }
    }
}
