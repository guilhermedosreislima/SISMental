using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class HistoricoAlteracoes : BaseEntity
    {
        public Guid id_registro_epidemiologico { get; set; }
        public RegistroEpidemiologico RegistroEpidemiologico { get; set; }
        public Guid id_usuario { get; set; }
        public Usuario Usuario { get; set; }
        public string descricao { get; set; }
        public DateTime data { get; set; }

        public HistoricoAlteracoes()
        {
        }
    }
}
