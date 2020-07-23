using Microsoft.Extensions.DependencyInjection;
using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.ConsoleApp.Command;
using Puc.Minas.Varejo.ConsoleApp.Query;
using Puc.Minas.Varejo.Domain.Entity;
using Puc.Minas.Varejo.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.ConsoleApp.Ioc
{
    public static class IocRegister
    {
        public static ServiceProvider RegisterDendencies(this ServiceCollection services)
        {
            return services
           .AddTransient<ICarrinhoCompraCommand, CarringoCompraCommand>()
           .AddTransient<ILivroQuery, LivroQuery>()
           .AddTransient<ILivroRepository, LivroRepository>()
           .AddTransient<ICarrinhoCompraRepository, CarrinhoCompraRepository>()
           .AddTransient<IPedidoRepository, PedidoRepository>()
           .AddTransient<IPedidoCommand, PedidoCommand>()
           .BuildServiceProvider();
        }
    }
}
