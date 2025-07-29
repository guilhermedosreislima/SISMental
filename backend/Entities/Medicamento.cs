using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Medicamento : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegEpidMedicamento> RegEpidMedicamentos { get; set; }
        public Medicamento()
        {
            RegEpidMedicamentos = new List<RegEpidMedicamento>();
        }
    }
}
