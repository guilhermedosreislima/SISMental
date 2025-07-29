using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Notificacao : BaseEntity
    {
        public Guid tipo_notificacao_id { get; set; }
        public TipoNotificacao TipoNotificacao { get; set; }
        public string mensagem { get; set; }
        public bool visualizada { get; set; }
        public Guid usuario_id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime data_visualizacao { get; set; }

        public Notificacao()
        {
        }
    }
}
