using Puc.Minas.Varejo.Application.Ports.Secondary.Repository;
using Puc.Minas.Varejo.ConsoleApp.Infra;
using Puc.Minas.Varejo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Infra.Repository
{
    public class LivroRepository : ILivroRepository
    {
        public List<Livro> ListaLivros()
        {
            return StaticClassDB.Livro;
        }
    }
}
