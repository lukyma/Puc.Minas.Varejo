using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Application.Ports.Primary
{
    public interface ICarrinhoCompraCommand
    {
        Carrinho AdicionarLivroCarrinho(string idCarrinho, Livro livro);
        Carrinho RemoverLivroCarrinho(string idCarrinho, Livro livro);
        Carrinho RetornarCarrinho(string idCarrinho);
    }
}
