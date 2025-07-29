using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class RegEpidDroga : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico registroEpidemiologico { get; set; }
        public Guid id_droga { get; set; }
        public Droga Droga { get; set; }

        public RegEpidDroga()
        {
        }
    }
}
