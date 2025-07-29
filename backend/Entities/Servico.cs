using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Servico : BaseEntity
    {
        public Guid id_municipio { get; set; }
        public Municipio Municipio { get; set; }
        public Guid id_tipo_servico { get; set; }
        public TipoServico TipoServico { get; set; }
        public Guid? id_coordenador { get; set; }
        public Usuario Coordenador { get; set; }
        public bool implantado { get; set; }
        public bool ativo { get; set; }
        public bool habilitado { get; set; }
        public DateTime data_habilitacao { get; set; }
        public string nome { get; set; }
        public string cnes { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public virtual ICollection<SolicitacaoTransferencia> SolicitacoesTransferencia { get; set; }
        public virtual ICollection<DigitadorServico> DigitadoresServicos { get; set; }


        public Servico()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
            SolicitacoesTransferencia = new List<SolicitacaoTransferencia>();
            DigitadoresServicos = new List<DigitadorServico>();
        }
    }
}
