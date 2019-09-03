using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;
        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }
        private string Mostrar()
        {
            return "el color es " + this.color + " y el tipo es " + this.tipo;
        }
        public static string Mostrar(Tinta t)
        {
            return t.Mostrar();
        }
        public static bool operator == (Tinta x, Tinta y)
        {
            if(!(object.ReferenceEquals(x,null))&&!(object.ReferenceEquals(y,null)))
            {
                   return ((x.color == y.color) && (x.tipo == y.tipo));
            }
            return false;
        }
        public static bool operator != (Tinta x , Tinta y)
        {
            return !(x == y);
        }
        public static bool operator == (Tinta x, ConsoleColor color)
        {
            return (x.color == color);
        }
        public static bool operator != (Tinta x , ConsoleColor color)
        {
            return !(x == color);
        }
        public static explicit operator string (Tinta t)
        {
            return t.Mostrar();
        }

    }
}
