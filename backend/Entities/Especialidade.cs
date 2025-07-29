using System;
using System.Collections.Generic;
using System.Text;

namespace backend.Entities
{
    public class Especialidade : BaseEntity
    {
        public string nome { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Prontuario> Prontuarios { get; set; }
        public Especialidade()
        {
            Usuarios = new List<Usuario>();
            Prontuarios = new List<Prontuario>();
        }
    }
}
