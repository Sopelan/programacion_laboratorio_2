using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;
        public Pluma()
        {
            this.marca = "sin marca";
            this.tinta = null;
            this.cantidad = 0;
        }
        public Pluma(string marca):this()
        {
            this.marca = marca;
        }
        public Pluma(string marca , Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca , Tinta tinta , int cantidad):this(marca,tinta)
        {
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "marca " + this.marca + " tinta " + Tinta.Mostrar(this.tinta) + " cantidad " + this.cantidad;
        }
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }
        public static bool operator == (Pluma p , Tinta t)
        {
            return (p.tinta == t);
        }
        public static bool operator != (Pluma p , Tinta t)
        {
            return !(p == t);
        }
        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p == t)
            {
                if(p.cantidad < 100)
                    p.cantidad++;
            }
            return p;
        }
    }
}
