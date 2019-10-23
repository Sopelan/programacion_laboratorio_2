using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;
       
        public Vehiculo (double precio)
        {
            _precio = precio;
        }
        public void MostrarPrecio()
        {
           Console.WriteLine( "precio: " + this._precio);
        }
    }
}
