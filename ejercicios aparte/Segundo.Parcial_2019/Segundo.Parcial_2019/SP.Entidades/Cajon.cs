using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Windows.Forms;
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
    public class Cajon <T> : ISerializar where T : Fruta
    {
        protected int _capacidad;
        protected List<T> _elementos;
        public double _precioUnitario;
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
                return this._precioUnitario * this._elementos.Count;
            }
            set
            {

            }
        }

        public Cajon()
        {
            this.eventoPrecio += Manejadora.Imprimir;
            this._elementos = new List<T>();
        }
        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(double precioUnitario, int capacidad):this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("capacidad: " + this._elementos.Count);
            sb.AppendLine("cantidad total: " + this._capacidad);
            sb.AppendLine("Precio Total: " + this.PrecioTotal);
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
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cajon<T>));
                xmlSerializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static Cajon<T> operator + (Cajon<T> cajon , T t)
        {
            if (cajon._capacidad > cajon._elementos.Count)
            {
                cajon._elementos.Add(t);
                if (cajon.PrecioTotal > 55)
                    cajon.eventoPrecio(cajon.PrecioTotal, EventArgs.Empty);
            }
            else
                MessageBox.Show(new CajonLlenoException().Message);
            return cajon;
        }
    }
}
