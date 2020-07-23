using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.ConsoleApp.Infra;
using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Minas.Varejo.Infra.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido FinalizarPedido(Carrinho carrinho)
        {
            Pedido pedido = new Pedido();
            foreach(var item in carrinho.Livros)
            {
                pedido.AdicionarItem(item);
            }
            StaticClassDB.Pedidos.Add(pedido);

            return pedido;
        }

        public List<Pedido> ListarPedidos()
        {
            return StaticClassDB.Pedidos;
        }

        public Pedido RetornarPedido(int id)
        {
            return StaticClassDB.Pedidos.FirstOrDefault(o => o.Id == id);
        }
    }
}
