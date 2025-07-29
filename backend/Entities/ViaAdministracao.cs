using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class ViaAdministracao : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegEpidMedicamento> RegEpidMedicamentos { get; set; }
        public ViaAdministracao()
        {
            RegEpidMedicamentos = new List<RegEpidMedicamento>();
        }
    }
}
