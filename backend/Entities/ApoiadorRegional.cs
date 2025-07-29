using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class ApoiadorRegional : BaseEntity
    {
        public Guid id_usuario { get; set; }
        public Usuario Usuario { get; set; }
        public Guid id_regional { get; set; }
        public Regional Regional { get; set; }

        public ApoiadorRegional()
        {
        }
    }
}
