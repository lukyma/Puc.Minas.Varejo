using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.ConsoleApp.Command;
using Puc.Minas.Varejo.ConsoleApp.Ioc;
using Puc.Minas.Varejo.Domain.Entity;
using Puc.Minas.Varejo.Domain.Exception;
using System;

namespace Puc.Minas.Varejo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider service = new ServiceCollection().RegisterDendencies();

            Console.WriteLine("Digite um comando a seguir! Digite Sair, para sair do programa!");

            Console.WriteLine("1 - Adicionar Livro no carrinho de compras!");

            string commando = Console.ReadLine();

            var commandCarrinho = service.GetService<ICarrinhoCompraCommand>();
            var commandPedido = service.GetService<IPedidoCommand>();
            var queryLivro = service.GetService<ILivroQuery>();

            while (commando != "Sair")
            {
                try
                {
                    Console.WriteLine("1 - Adicionar Livro no carrinho de compras! \n" + 
                                      "2 - Finalizar pedito");
                    commando = Console.ReadLine();
                    if (commando == "1")
                    {
                       
                        Console.WriteLine("Digite o id do carrinho, caso já tenha um carrinho de compras!");
                        var idCarrinho = Console.ReadLine();
                        Console.WriteLine("Digite o id do livro, para adicion-lo ao carrinho!");
                        foreach (var livro in queryLivro.ListarLivros())
                        {
                            Console.WriteLine($"Id: {livro.Id} \n Nome: {livro.Nome} \n ISBN: {livro.Isbn}");
                        }

                        string idLivro = Console.ReadLine();

                        queryLivro.PegarLivro(int.Parse(idLivro));

                        var carrinho = commandCarrinho.AdicionarLivroCarrinho(idCarrinho, queryLivro.PegarLivro(int.Parse(idLivro)));
                        Console.WriteLine($"Id do carrinho: {carrinho.Id}");
                    }
                    else if(commando == "2")
                    {
                        Console.WriteLine("Digite o id do carrinho, para finalizar o pedido!");

                        string idCarrinho = Console.ReadLine();

                        var carrinho = commandCarrinho.RetornarCarrinho(idCarrinho);

                        Pedido pedido = commandPedido.FinalizarPedido(carrinho);

                        Console.WriteLine("Pedido finalizado com sucesso! \n ------------------\n Detalhes: \n");

                        Console.WriteLine($"Numero pedido: {pedido} \n Valor: {pedido.Valor} \n Itens: ");
                        pedido.Itens.ForEach(o => { Console.WriteLine($"Nome livro: {o.Nome} ISBN: {o.Isbn}"); });
                    }
                }
                catch(DomainException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
