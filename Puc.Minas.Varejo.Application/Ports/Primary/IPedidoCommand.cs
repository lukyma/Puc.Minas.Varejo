using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Application.Ports.Primary
{
    public interface IPedidoCommand
    {
        Pedido FinalizarPedido(Carrinho carrinho);
        List<Pedido> ListarPedidos();
        Pedido RetornarPedidos(int id);
    }
}
