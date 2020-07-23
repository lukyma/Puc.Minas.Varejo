using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.Domain.Entity;
using Puc.Minas.Varejo.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.ConsoleApp.Command
{
    public class CarringoCompraCommand : ICarrinhoCompraCommand
    {
        private ICarrinhoCompraRepository repository { get; }
        public CarringoCompraCommand(ICarrinhoCompraRepository repository)
        {
            this.repository = repository;
        }

        public Carrinho AdicionarLivroCarrinho(string idCarrinho, Livro livro)
        {
            return repository.AdicionarLivroCarrinho(idCarrinho, livro);
        }

        public Carrinho RemoverLivroCarrinho(string idCarrinho, Livro livro)
        {
            return repository.RemoverLivroCarrinho(idCarrinho, livro);
        }

        public Carrinho RetornarCarrinho(string idCarrinho)
        {
            return repository.RetornarCarrinho(idCarrinho);
        }
    }
}
