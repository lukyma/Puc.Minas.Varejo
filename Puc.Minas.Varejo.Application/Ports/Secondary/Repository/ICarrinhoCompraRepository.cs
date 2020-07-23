using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Application.Ports.Secondary.Repository
{
    public interface ICarrinhoCompraRepository
    {
        Carrinho AdicionarLivroCarrinho(string idCarrinho, Livro entity);
        Carrinho RemoverLivroCarrinho(string idCarrinho, Livro entity);
        Carrinho RetornarCarrinho(string idCarrinho);
    }
}
