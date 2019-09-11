using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._06.Entidades
{
    public class Paleta
    {
        public Tempera[] Temperas { get { return colores; } }
        private Tempera[] colores;
        private int cantidadMaximaColores;
        private Paleta() : this(5)
        {

        }
        private Paleta(int cantidad)
        {
            this.cantidadMaximaColores = cantidad;
            colores = new Tempera[cantidad];
        }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta paleta = new Paleta(cantidad);
            return paleta;
        }
        private string Mostrar()
        {
            int cantidad;
            string men;
            string mensaje = "cantidad de colores " + this.cantidadMaximaColores;
            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                cantidad = i + 1;
                men = (string)this.colores[i];
                mensaje += "\n "+ cantidad + ". " + men;
            }
            return mensaje;
        }
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }
        public static bool operator ==(Paleta p, Tempera t)
        {
            for (int i = 0; i < p.cantidadMaximaColores; i++)
            {
                if (p.colores[i] == t)
                    return true;
            }
            return false;

        }
        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }
        public static Paleta operator +(Paleta p, Tempera t)
        {
            if((!Object.Equals(p,null)&& t != null))
            {
                if (p != t)
                {
                    int num = p.ObtenerLugarLbre();
                    if (num != -1)
                    p.colores[num] = t;
                }
                else
                {
                    int num = buscar(p, t);
                    if(num != -1)
                    p.colores[num] += t;
                
                }
                
            }
            return p;
        }
        private int ObtenerLugarLbre()
        {
            for(int i = 0 ; i < this.cantidadMaximaColores ; i++)
            {
                if (Object.Equals(this.colores[i],null))
                    return i;
            }
            return -1;
        }
        public static int operator | (Paleta p , Tempera t)
        {
            for (int i = 0; i < p.cantidadMaximaColores; i++)
            {
                if (p.colores[i] == t)
                {
                    return i;
                }
                    
            }
            return -1;

        }
        public static Paleta operator -(Paleta p ,Tempera t)
        {
            int num = buscar(p, t);
            //int c = p.colores[num].getCantidad;
            if (p == t && (!Object.Equals(p,null) && t != null && num != -1))
            {
                if (p.colores[num].getCantidad > t.getCantidad)
                    p.colores[num].getCantidad -= t.getCantidad;
                else
                    p.colores[num] = null;
            }
            return p;
        }
        public static int buscar(Paleta p , Tempera t)
        {
            if (!Object.Equals(p,null) && t != null)
            {
                for (int i = 0; i<p.colores.Length; i++)
                {
                if (p.colores[i] == t)
                     return i;
                }
                
            }
            return -1;
        }
    }
}
