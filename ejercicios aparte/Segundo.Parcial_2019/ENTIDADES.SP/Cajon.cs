using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
//Crear la clase Cajon<T>
//atributos: _capacidad:int, _elementos:List<T> y _precioUnitario:double (todos protegidos)        
//Propiedades
//Elementos:(sólo lectura) expone al atributo de tipo List<T>.
//PrecioTotal:(sólo lectura) retorna el precio total del cajón (precio * cantidad de elementos).
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
    public class Cajon<T> : ISerializar  where T : Fruta
    {
        protected int _cantidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public delegate void EventoPrecio(double precio, EventArgs e);
        public event EventoPrecio eventoPrecio;
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
                return this.Cantidad * this._precioUnitario;
            }
            set
            {
                this._precioUnitario = value;
            }
        }

        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public Cajon()
        {
            this.Cantidad = 0;
            this._elementos = new List<T>();
            this._precioUnitario = 0;
            this.eventoPrecio += Manejadora.Imprimir;
        }
        public Cajon(int cantidad):this()
        {
            this.Cantidad = cantidad;
        }
        public Cajon(double precioUnitario, int cantidad):this(cantidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T elemento)
        {
            if (cajon.Cantidad > cajon._elementos.Count)
            {
                cajon._elementos.Add(elemento);
                if(cajon.PrecioTotal > 55)
                    cajon.eventoPrecio(cajon.PrecioTotal ,EventArgs.Empty);
            } 
            else
                throw new CajonLlenoException();
            return cajon;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cajon: ");
            foreach(T t in this._elementos)
            {
                sb.AppendLine(t.ToString());
            }
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path)));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cajon<T>));
                xmlSerializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
