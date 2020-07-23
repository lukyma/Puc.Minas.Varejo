using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Application.Ports.Secondary.Repository
{
    public interface IPedidoRepository
    {
        Pedido FinalizarPedido(Carrinho carrinho);
        List<Pedido> ListarPedidos();
        Pedido RetornarPedido(int id);
    }
}
