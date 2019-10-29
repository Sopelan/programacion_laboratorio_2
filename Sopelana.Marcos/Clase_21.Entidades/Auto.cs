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
    public class Auto : IXml
    {
        public string marca;
        public double precio;
        private Auto()
        {

        }
        public Auto(string marca , double precio):this()
        {
            this.marca = marca;
            this.precio = precio;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("marca: " + this.marca);
            sb.AppendLine("precio: " + this.precio);
            return sb.ToString();
        }

        public bool Guardar(string texto)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Auto));
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
                XmlSerializer xml = new XmlSerializer(typeof(Auto));
                TextReader textReader = new StreamReader(texto);
                obj = (Auto)xml.Deserialize(textReader);
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
