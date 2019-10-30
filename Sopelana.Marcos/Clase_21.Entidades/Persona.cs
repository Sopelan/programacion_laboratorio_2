using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
namespace Clase_21.Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]
    public class Persona : IXml
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodo;
        public List<string> apodos { get { return apodo; } }
        public int Edad { get{return edad;}set { edad = value; } }
        public Persona()
        {
            this.apodo = new List<string>();
        }
        public Persona(string nombre,string apellido,int edad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.Append("Apellido: " + this.apellido);
            return sb.ToString();
        }

        public bool Guardar(string texto)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                TextWriter streamWriter = new StreamWriter(texto);
                xml.Serialize(streamWriter, this);
                Console.WriteLine(this.ToString());
                streamWriter.Close();
                return true;
            }

            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public bool Leer(string texto, out object obj)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                TextReader textReader = new StreamReader(texto);
                obj = (Persona)xml.Deserialize(textReader);
                Console.WriteLine(this.ToString());
                textReader.Close();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                obj = null;
                return false;
            }
        }
    }
}
