using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Auto : Vehiculo
    {
        public ETipo tipo;

        public Auto(string modelo , float precio , Fabricante fabri,ETipo tipo):base(precio,modelo,fabri)
        {
            this.tipo = tipo;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            return false;
        }
        public static  explicit operator Single(Auto a)
        {
            return a.precio;
        }
        public static bool operator != (Auto a, Auto b)
        {
            return !(a == b);
        }
        public static bool operator ==(Auto a, Auto b)
        {
            return (a.tipo == b.tipo) && ((Vehiculo)a == (Vehiculo)b);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine("tipo: " + this.tipo);
            return sb.ToString();
        }
    }
}
