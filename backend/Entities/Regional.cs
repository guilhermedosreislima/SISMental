using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Regional : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<ApoiadorRegional> ApoiadoresRegionais { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }
        public Regional()
        {
            ApoiadoresRegionais = new List<ApoiadorRegional>();
            Municipios = new List<Municipio>();
        }
    }
}
