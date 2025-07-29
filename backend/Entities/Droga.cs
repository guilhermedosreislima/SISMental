using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Droga : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegEpidDroga> RegEpidDrogas { get; set; }
        public Droga()
        {
            RegEpidDrogas = new List<RegEpidDroga>();
        }
    }
}
