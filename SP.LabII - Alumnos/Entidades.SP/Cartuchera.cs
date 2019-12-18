using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Crear la clase Cartuchera<T> -> restringir para que solo lo pueda usar Utiles o clases que deriven de Utiles
//atributos: capacidad:int y elementos:List<T> (todos protegidos)        
//Propiedades
//Elementos:(sólo lectura) expone al atributo de tipo List<T>.
//PrecioTotal:(sólo lectura) retorna el precio total de la cartuchera (la suma de los precios de sus elementos).
//Constructor
//Cartuchera(), Cartuchera(int); 
//El constructor por default es el único que se encargará de inicializar la lista.
//Métodos
//ToString: Mostrará en formato de tipo string: 
//el tipo de cartuchera, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
//de todos los elementos contenidos en la misma. Reutilizar código.
//Sobrecarga de operador
//(+) Será el encargado de agregar elementos a la cartuchera siempre y cuando no supere la capacidad máxima de la misma.
namespace Entidades.SP
{
    public class Cartuchera<T> where T : Utiles
    {
        protected int capacidad;
        protected List<T> elementos;
        public delegate void EventoPrecio(Cartuchera<T> c ,EventArgs e);
        public event EventoPrecio eventoPrecio;

        public List<T> Elementos
        {
            get
            {
                return this.elementos;
            }
        }
        public double PrecioTotal
        {
            get
            {
                double suma = 0;
                foreach (T t in elementos)
                {
                    suma += t.precio;
                }
                return suma;
            }
        }

        public Cartuchera()
        {
            this.elementos = new List<T>();
        }
        public Cartuchera(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static Cartuchera<T> operator +(Cartuchera<T> cartuchera , T t)
        {
            if (cartuchera.elementos.Count < cartuchera.capacidad)
            {
                cartuchera.elementos.Add(t);
                if (cartuchera.PrecioTotal > 85)
                    cartuchera.eventoPrecio(cartuchera,new EventArgs());
            }
            else
                 throw new CartucheraLlenaException();
                
            return cartuchera;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Capacidad: " + this.capacidad);
            sb.AppendLine("Capacidad Actual: " + this.elementos.Capacity);
            sb.AppendLine("Precio Total: " + this.PrecioTotal);
            foreach (T t in this.elementos)
                sb.AppendLine(t.ToString());
            return sb.ToString();
        }

    }
}
