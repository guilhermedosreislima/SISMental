using SESMA.SISMENTAL.Model.Entities.DadosClinicos;
using SESMA.SISMENTAL.Model.Entities.DadosDemograficos;
using SESMA.SISMENTAL.Model.Entities.DadosSocioeconomicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class RegistroEpidemiologico : BaseEntity
    {
        public Guid id_usuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Guid id_servico { get; set; }
        public virtual Servico Servico { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public string cpf { get; set; }
        public string cartao_sus { get; set; }
        public string endereco { get; set; }
        public Guid id_sexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        public string data_nascimento { get; set; }
        public Guid id_cor_raca { get; set; }
        public virtual CorRaca CorRaca { get; set; }
        public Guid id_estado_civil { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public Guid id_escolaridade { get; set; }
        public virtual Escolaridade Escolaridade { get; set; }
        public DateTime data_primeiro_acolhimento { get; set; }
        public DateTime? data_ultima_readmissao { get; set; }
        public Guid id_procedencia { get; set; }
        public virtual Procedencia Procedencia { get; set; }
        public Guid id_regime_ocupacional { get; set; }
        public virtual RegimeOcupacional RegimeOcupacional { get; set; }
        public Guid? id_ocupacao { get; set; }
        public virtual Ocupacao Ocupacao { get; set; }
        public Guid id_beneficio { get; set; }
        public virtual Beneficio Beneficio { get; set; }
        public Guid id_tipo_moradia { get; set; }
        public virtual TipoMoradia TipoMoradia { get; set; }
        public Guid id_zona_residencia { get; set; }
        public virtual ZonaResidencia ZonaResidencia { get; set; }
        public Guid id_area_cobertura_moradia { get; set; }
        public virtual AreaCoberturaMoradia AreaCoberturaMoradia { get; set; }
        public Guid id_quantidade_pessoas_familia { get; set; }
        public virtual QuantidadePessoasFamilia QuantidadePessoasFamilia { get; set; }
        public Guid id_religiao { get; set; }
        public virtual Religiao Religiao { get; set; }
        public Guid id_conflito_lei { get; set; }
        public virtual ConflitoLei ConfitoLei { get; set; }
        public string hipotese_diagnostico { get; set; }
        public Guid? id_diagnostico_principal { get; set; }
        public virtual PatologiaCid10 DiagnosticoPrincipal { get; set; }
        public Guid? id_diagnostico_secundario { get; set; }
        public virtual PatologiaCid10 DiagnosticoSecundario { get; set; }
        public int idade_inicio_sintomas { get; set; }
        public Guid id_internacao_psiquiatrica { get; set; }
        public virtual InternacaoPsiquiatrica InternacaoPsiquiatrica { get; set; }
        public Guid id_numero_internacao_psiquiatrica { get; set; }
        public virtual NumeroInternacaoPsiquiatrica NumeroInternacaoPsiquiatrica { get; set; }
        public DateTime? data_inicio_tratamento { get; set; }
        public Guid id_doencas_psiquiatricas_familia { get; set; }
        public virtual DoencaPsiquiatricaFamilia DoencaPsiquiatricasFamilia { get; set; }
        public Guid id_uso_drogas { get; set; }
        public virtual UsoDrogas UsoDrogas { get; set; }
        public DateTime? data_inicio_uso_drogas { get; set; }
        public Guid id_uso_drogas_familia { get; set; }
        public virtual UsoDrogasFamilia UsoDrogasFamilia { get; set; }
        public Guid id_situacao_prontuario { get; set; }
        public virtual SituacaoProntuario SituacaoProntuario { get; set; }
        public Guid id_pensou_suicidio { get; set; }
        public virtual PensouSuicidio PensouSuicidio { get; set; }
        public Guid id_tentou_suicidio { get; set; }
        public virtual TentouSuicidio TentouSuicidio { get; set; }
        public Guid id_pensou_automutilar { get; set; }
        public virtual PensouAutomutilar PensouAutomutilar { get; set; }
        public Guid id_tentou_automutilar { get; set; }
        public virtual TentouAutomutilar TentouAutomutilar { get; set; }
        public Guid id_situacao_paciente { get; set; }
        public virtual SituacaoPaciente SituacaoPaciente { get; set; }
        public DateTime? data_atualizacao { get; set; }
        public DateTime? data_alta { get; set; }
        public DateTime? data_obito { get; set; }

        public virtual ICollection<SolicitacaoEditar> SolicitacoesEditar { get; set; }
        public virtual ICollection<SolicitacaoTransferencia> SolicitacoesTransferencia { get; set; }
        public virtual ICollection<SolicitacaoVisualizar> SolicitacoesVisualizar { get; set; }
        public virtual ICollection<HistoricoAlteracoes> HistoricosAlteracao { get; set; }
        public virtual ICollection<Prontuario> Prontuarios { get; set; }
        public virtual ICollection<RegEpidDroga> RegEpidDrogas { get; set; }
        public virtual ICollection<RegEpidPatCid10> RegEpidPatCid10s { get; set; }
        public virtual ICollection<RegEpidPatPredef> RegEpidPatPredefs { get; set; }
        public virtual ICollection<RegEpidMedicamento> RegEpidMedicamentos { get; set; }
        public RegistroEpidemiologico()
        {
            SolicitacoesEditar = new List<SolicitacaoEditar>();
            SolicitacoesTransferencia = new List<SolicitacaoTransferencia>();
            SolicitacoesVisualizar = new List<SolicitacaoVisualizar>();
            HistoricosAlteracao = new List<HistoricoAlteracoes>();
            Prontuarios = new List<Prontuario>();
            RegEpidDrogas = new List<RegEpidDroga>();
            RegEpidPatCid10s = new List<RegEpidPatCid10>();
            RegEpidPatPredefs = new List<RegEpidPatPredef>();
            RegEpidMedicamentos = new List<RegEpidMedicamento>();
        }
    }
}
