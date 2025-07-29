using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class RegEpidPatCid10 : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_patologia_cid10 { get; set; }
        public PatologiaCid10 PatologiaCid10 { get; set; }


        public RegEpidPatCid10()
        {
        }
    }
}
