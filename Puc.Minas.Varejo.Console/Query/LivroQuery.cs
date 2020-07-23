using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.Domain.Entity;
using Puc.Minas.Varejo.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Minas.Varejo.ConsoleApp.Query
{
    public class LivroQuery : ILivroQuery
    {
        private ILivroRepository livroRepository { get; }
        public LivroQuery(ILivroRepository livroRepository)
        {
            this.livroRepository = livroRepository;
        }
        public List<Livro> ListarLivros()
        {
            return livroRepository.ListaLivros();
        }

        public Livro PegarLivro(int id)
        {
            var livro = livroRepository.ListaLivros().FirstOrDefault(o => o.Id == id);
            if(livro == null)
            {
                throw new DomainException("Livro não encontrado!");
            }

            return livro;
        }
    }
}
