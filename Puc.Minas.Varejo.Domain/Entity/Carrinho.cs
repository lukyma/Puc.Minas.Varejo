using Puc.Minas.Varejo.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Minas.Varejo.Domain.Entity
{
    public class Carrinho : Entity<string>
    {
        public Carrinho(Livro livro)
        {
            Id = Guid.NewGuid().ToString();
            Livros = new List<Livro>();
            AdicionarLivro(livro);
        }

        public void AdicionarLivro(Livro livro)
        {
            if(Livros.Any(o => o.Id == livro.Id))
            {
                throw new DomainException("Livro já adicionado!");
            }
            Livros.Add(livro);
        }

        public List<Livro> Livros { get; private set; }

        public decimal ValorTotal
        {
            get
            {
                return Livros.Sum(o => o.Preco);
            }
        }
    }
}
