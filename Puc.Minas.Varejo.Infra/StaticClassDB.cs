using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.ConsoleApp.Infra
{
    public static class StaticClassDB
    {
        public static List<Carrinho> Carrinho = new List<Carrinho>();
        public static List<Livro> Livro = new List<Livro>() 
        {
            new Livro()
            {
                Id = 1,
                Isbn = "123456",
                Nome = "A vida de Lucas",
                Preco = 50,
                Autores = new List<Autor>()
                {
                    new Autor()
                    {
                        Nome = "Lucas"
                    }
                }
            },
            new Livro()
            {
                Id = 2,
                Isbn = "123456",
                Nome = "Arquitetura de software distribuído",
                Preco = 50,
                Autores = new List<Autor>()
                {
                    new Autor()
                    {
                        Nome = "PUC MINAS"
                    }
                }
            }
        };
        public static List<Autor> Autor = new List<Autor>();
        public static List<Pedido> Pedidos = new List<Pedido>();
    }
}
