using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puc.Minas.Varejo.Domain.Entity
{
    public class Pedido : Entity<int>
    {
        public Pedido()
        {
            Itens = new List<Livro>();
        }
        public decimal Valor
        {
            get
            {
                return Itens.Sum(o => o.Preco);
            }
        }
        public void AdicionarItem(Livro livro)
        {
            Itens.Add(livro);
        }
        public List<Livro> Itens { get; set; }
    }
}
