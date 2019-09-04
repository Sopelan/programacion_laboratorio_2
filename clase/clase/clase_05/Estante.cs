using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05
{
    public class Estante
    {
        private Producto producto[];
        private int ubicacionEstantes;
        private Estante(int capacidad)
        {
            
        }
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstantes = ubicacion;
        }
        public Producto[] GetProducto()
        {
            return this.producto[];
        }
        public string MostrarEstante (Estante e)
        {
            return e
        }
        public static bool operator ==(Estante e , Producto p)
        {

        }
        public static bool operator !=(Estante e, Producto p)
        {

        }
        public static bool operator +(Estante e , Producto p)
        {

        }
        public static Estante operator -(Estante e , Producto p)
        {

        }

    }
}
