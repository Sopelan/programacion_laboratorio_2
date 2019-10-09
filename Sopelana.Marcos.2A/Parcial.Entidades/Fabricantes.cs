using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        public static implicit operator String(Fabricante f)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("marca: " + f.marca );
            sb.AppendLine("pais: " + f.pais);
            return sb.ToString();
        }
        public static bool operator != (Fabricante a , Fabricante b)
        {
            return !(a == b);
        }
        public static bool operator == (Fabricante a , Fabricante b)
        {
            return (a.marca == b.marca) && (a.pais == b.pais);
        }
    }
}
