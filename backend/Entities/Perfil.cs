using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace backend.Entities
{
    public class Perfil : IdentityRole<Guid>
    {
        public ICollection<Usuario> Usuarios { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public Perfil()
        {
            Usuarios = new List<Usuario>();
        }
    }
}
