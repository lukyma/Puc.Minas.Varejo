using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Application.Ports.Primary
{
    public interface ILivroQuery
    {
        List<Livro> ListarLivros();
        Livro PegarLivro(int id);
    }
}
