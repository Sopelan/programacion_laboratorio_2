using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._06.Entidades
{
    public class Tempera
    {

        public int getCantidad { get { return cantidad; }set { cantidad = value; } }
        private ConsoleColor color;
        private string marca;
        private int cantidad;
        public Tempera(ConsoleColor color , string marca , int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string mostrar()
        {
            return "el color de la tempera es " + this.color + " la marca es " + this.marca + " y tiene " + this.cantidad;
        }
        public static implicit operator string(Tempera t)
        {
            if(t != null)
                return t.mostrar();
            return "";
                      
        }
        public static bool operator ==(Tempera t1 , Tempera t2)
        {
            if (!object.Equals(t1, null) && (!object.Equals(t2, null)))
                return ((t1.marca == t2.marca) && (t1.color == t2.color));
            else
                if (object.Equals(t1, null) && (object.Equals(t2, null)))
                return true;
                else
                return false;

        }
        public static bool operator !=(Tempera t1 , Tempera t2)
        {
            return !(t1 == t2);
        }
        public static Tempera operator +(Tempera t , int n)
        {
            if(t != null)
            {
                t.cantidad += n;
            }
            
            return t;
        }
        public static Tempera operator + (Tempera t1 , Tempera t2)
        {
            if(t1 == t2)
            {
                t1 += t2.cantidad;
                
            }
            return t1;
        }
        public static Tempera operator -(Tempera t, int n)
        {
            if (t != null && t.cantidad > 1)
            {
                t.cantidad -= n;
                return t;
            }
            return t;
            
        }
    }
}
