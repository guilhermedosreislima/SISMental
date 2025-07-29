using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Prontuario : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_usuario { get; set; }
        public Usuario Usuario { get; set; }
        public Guid id_especialidade { get; set; }
        public Especialidade Especialidade { get; set; }
        public string atividade { get; set; }
        public DateTime data_atividade { get; set; }

        public Prontuario()
        {
        }
    }
}
