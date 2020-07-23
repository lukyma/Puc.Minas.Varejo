using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.ConsoleApp.Infra;
using Puc.Minas.Varejo.Domain.Entity;
using Puc.Minas.Varejo.Domain.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Minas.Varejo.Infra.Repository
{
    public class CarrinhoCompraRepository : ICarrinhoCompraRepository
    {
        public Carrinho AdicionarLivroCarrinho(string idCarrinho, Livro livro)
        {
            var carrinho = StaticClassDB.Carrinho.FirstOrDefault(o => o.Id == idCarrinho);
            if(carrinho == null)
            {
                carrinho = new Carrinho(livro);
                StaticClassDB.Carrinho.Add(carrinho);
            }
            else
            {
                carrinho.AdicionarLivro(livro);
            }

            return carrinho;
        }

        public Carrinho RemoverLivroCarrinho(string idCarrinho, Livro livro)
        {
            var carrinho = StaticClassDB.Carrinho.FirstOrDefault(o => o.Id == idCarrinho);
            if (carrinho == null)
            {
                throw new DomainException("Carrinho não encontrado");
            }
            else
            {
                carrinho.AdicionarLivro(livro);
            }

            return carrinho;
        }

        public Carrinho RetornarCarrinho(string idCarrinho)
        {
            var carrinho = StaticClassDB.Carrinho.FirstOrDefault(o => o.Id == idCarrinho);
            if (carrinho == null)
            {
                throw new DomainException("Carrinho não encontrado");
            }
            return carrinho;
        }
    }
}
