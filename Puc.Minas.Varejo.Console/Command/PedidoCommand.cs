using Puc.Minas.Varejo.Application.Ports.Primary;
using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.ConsoleApp.Command
{
    public class PedidoCommand : IPedidoCommand
    {
        private IPedidoRepository pedidoRepository { get; }
        public PedidoCommand(IPedidoRepository pedidoRepository)
        {
            this.pedidoRepository = pedidoRepository;
        }
        public Pedido FinalizarPedido(Carrinho carrinho)
        {
            return pedidoRepository.FinalizarPedido(carrinho);
        }

        public List<Pedido> ListarPedidos()
        {
            return pedidoRepository.ListarPedidos();
        }

        public Pedido RetornarPedidos(int id)
        {
            return pedidoRepository.RetornarPedido(id);
        }
    }
}
