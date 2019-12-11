using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.SP
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException() : base("esta llena la cartuchera")
        {

        }

        public string InformarNovedad()
        {
            return "esta llena la cartuchera";
        }
    }
}
