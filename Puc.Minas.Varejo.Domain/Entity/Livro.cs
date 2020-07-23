using System;
using System.Collections.Generic;

namespace Puc.Minas.Varejo.Domain.Entity
{
    public class Livro : Entity<int>
    {
        public string Nome { get; set; }
        public string Isbn { get; set; }
        public decimal Preco { get; set; }
        public virtual ICollection<Autor> Autores { get; set; }
    }
}
