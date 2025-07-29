using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class RegEpidPatPredef : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_patologia_predefinida { get; set; }
        public PatologiaPredefinida PatologiaPredefinida { get; set; }
        public RegEpidPatPredef()
        {
        }
    }
}
