using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Minas.Varejo.Domain.Exception
{
    public class DomainException : System.Exception
    {
        public DomainException()
        {

        }
        public DomainException(string message) : base(message)
        {

        }
    }
}
