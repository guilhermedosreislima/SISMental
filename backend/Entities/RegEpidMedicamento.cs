using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class RegEpidMedicamento : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_medicamento { get; set; }
        public Medicamento Medicamento { get; set; }
        public Guid id_periodicidade { get; set; }
        public Periodicidade Periodicidade { get; set; }
        public Guid id_via_administracao { get; set; }
        public ViaAdministracao ViaAdministracao { get; set; }
        public decimal posologia { get; set; }

        public RegEpidMedicamento()
        {
        }
    }
}
