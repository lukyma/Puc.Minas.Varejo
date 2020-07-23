using Microsoft.Extensions.DependencyInjection;
using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.Console.Command;
using Puc.Minas.Varejo.Infra.Repository;
using System;

namespace Puc.Minas.Varejo.Ioc
{
    public static class NativeBootstrapInit
    {
        public static void RegisterDependencies(this ServiceCollection services)
        {
            services
            .AddTransient<ICarrinhoCompraCommand, CarringoCompraCommand>()
            .AddTransient<ICarrinhoCompraRepository, CarrinhoCompraRepository>()
            .BuildServiceProvider();
        }
    }
}
