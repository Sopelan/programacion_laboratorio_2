using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
//Crear la clase Cajon<T>
//atributos: _capacidad:int, _elementos:List<T> y _precioUnitario:double (todos protegidos)
//Propiedades
//Elementos:(sólo lectura) expone al atributo de tipo List<T>.
//PrecioTotal:(sólo lectura) retorna el precio total del cajón (precio* cantidad de elementos).
//Constructor
//Cajon(), Cajon(int), Cajon(double, int);
//El por default: es el único que se encargará de inicializar la lista.
//Métodos
//ToString: Mostrará en formato de tipo string, la capacidad, la cantidad total de elementos, el precio total
//y el listado de todos los elementos contenidos en el cajón. Reutilizar código.
//Sobrecarga de operador
//(+) Será el encargado de agregar elementos al cajón, siempre y cuando no supere la capacidad del mismo.
namespace ENTIDADES.SP
{
    public class Cajon<T> : ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this._capacidad * this._precioUnitario;
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
            this._capacidad = 0;
            this._precioUnitario = 0;
        }
        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(double precioUnitario , int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public static Cajon<T> operator +(Cajon<T> Cajon , T t)
        {
            if(Cajon._capacidad > Cajon._elementos.Count && t != null)
            {
                Cajon._elementos.Add(t);
            }
            return Cajon;
                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cajon");
            sb.AppendLine("Capacidad: " + this._capacidad);
            sb.AppendLine("Cantidad total de elementos: " + this.Elementos.Count);
            sb.AppendLine("El precio Total: " + this.PrecioTotal);
            for(int i = 0; i < this._elementos.Count; i++)
            {
                sb.AppendLine(this._elementos[i].ToString());
            }
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Cajon<T>));
                TextWriter streamWriter = new StreamWriter(@"D:\VisualStudio\programacion_laboratorio_2\" + path);
                xml.Serialize(streamWriter,this);
                
                streamWriter.Close();
                return true;
            }

            catch (Exception exception)
            {
               
                return false;
            }
        }
    }
}
