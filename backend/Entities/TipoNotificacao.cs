using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class TipoNotificacao : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<Notificacao> Notificacoes { get; set; }
        public TipoNotificacao()
        {
            Notificacoes = new List<Notificacao>();
        }
    }
}
