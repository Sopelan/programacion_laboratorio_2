using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05
{
    public class Estante
    {
        private Producto[] producto;
        private int ubicacionEstantes;
        private Estante(int capacidad)
        {
            producto = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstantes = ubicacion;
        }
        public Producto[] GetProducto()
        {
            return this.producto;
        }
        public static string MostrarEstante(Estante e)
        {
            string mensaje;
            mensaje = "la ubicacion de estantes es " + e.ubicacionEstantes;
            for (int i = 0; i < e.producto.Length-1; i++)
            {
                mensaje += "\n " + Producto.MostrarProducto(e.producto[i]);
            }
            return mensaje;
        }
        public static bool operator ==(Estante e , Producto p)
        {
            int i;
            if(!Object.Equals(e,null) && (!Object.Equals(p,null)))
            {
                for(i = 0; i < e.producto.Length; i++)
                {
                    if(e.producto[i] == p)
                        return true;
                }
                return false;
            }
            return false;
           
            
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e , Producto p)
        {
            for (int i = 0; i < e.producto.Length; i++)
            {
                if(Object.Equals(e.producto[i],null)&& !(e == p))
                {
                    e.producto[i] = p;
                    return true;
                }
                
            }
            return false;
        }
        public static Estante operator -(Estante e , Producto p)
        {
            if (e == p)
            {
                return e;
            }
            return null;
        }

    }
}
