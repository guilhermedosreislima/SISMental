using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Periodicidade : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegEpidMedicamento> RegEpidMedicamentos { get; set; }
        public Periodicidade()
        {
            RegEpidMedicamentos = new List<RegEpidMedicamento>();
        }
    }
}
