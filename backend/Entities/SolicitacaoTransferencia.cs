using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class SolicitacaoTransferencia : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public virtual RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_solicitante { get; set; }
        public virtual Usuario Solicitante { get; set; }
        public Guid id_novo_servico { get; set; }
        public virtual Servico NovoServico { get; set; }
        public int status { get; set; }
        public int dias { get; set; }
        public string justificativa { get; set; }
        public string parecer { get; set; }
        public SolicitacaoTransferencia()
        {
        }
    }
}
