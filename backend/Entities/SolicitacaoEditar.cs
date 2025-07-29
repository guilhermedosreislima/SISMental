using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class SolicitacaoEditar : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public virtual RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_usuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int status { get; set; }
        public int dias { get; set; }
        public string justificativa { get; set; }
        public string parecer { get; set; }
        public DateTime? data_autorizacao { get; set; }

        public SolicitacaoEditar()
        {
        }
    }
}
