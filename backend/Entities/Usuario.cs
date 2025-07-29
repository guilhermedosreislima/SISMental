using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Usuario : IdentityUser<Guid>
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string password { get; set; }
        public string telefone { get; set; }
        public Guid? perfil_id { get; set; }
        public virtual Perfil Perfil { get; set; }
        public Guid? especialidade_id { get; set; }
        public virtual Especialidade Especialidade { get; set; }
        public bool primeiro_acesso { get; set; }
        public bool ativo { get; set; }
        public DateTime data_criacao { get; set; }
        public DateTime? data_alteracao { get; set; }
        public DateTime? data_inativacao { get; set; }

        public virtual ICollection<RegistroEpidemiologico> RegistrosEpidemiologicos { get; set; }
        public virtual ICollection<SolicitacaoEditar> SolicitacoesEditar { get; set; }
        public virtual ICollection<SolicitacaoTransferencia> SolicitacoesTransferencia { get; set; }
        public virtual ICollection<SolicitacaoVisualizar> SolicitacoesVisualizar { get; set; }
        public virtual ICollection<Notificacao> Notificacoes { get; set; }
        public virtual ICollection<ApoiadorRegional> ApoiadoresRegionais { get; set; }
        public virtual ICollection<DigitadorServico> DigitadoresServicos { get; set; }
        public virtual ICollection<HistoricoAlteracoes> HistoricosAlteracao { get; set; }
        public virtual ICollection<Prontuario> Prontuarios { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }

        public Usuario()
        {
            RegistrosEpidemiologicos = new List<RegistroEpidemiologico>();
            SolicitacoesEditar = new List<SolicitacaoEditar>();
            SolicitacoesTransferencia = new List<SolicitacaoTransferencia>();
            SolicitacoesVisualizar = new List<SolicitacaoVisualizar>();
            Notificacoes = new List<Notificacao>();
            ApoiadoresRegionais = new List<ApoiadorRegional>();
            HistoricosAlteracao = new List<HistoricoAlteracoes>();
            Prontuarios = new List<Prontuario>();
            Servicos = new List<Servico>();

        }
    }
}
