using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class PatologiaPredefinida : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<RegEpidPatPredef> RegEpidPatPredefs { get; set; }
        public PatologiaPredefinida()
        {
            RegEpidPatPredefs = new List<RegEpidPatPredef>();
        }
    }
}
