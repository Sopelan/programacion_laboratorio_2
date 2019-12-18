using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
//Lapiz-> color:ConsoleColor(publico); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; publico); PreciosCuidados->true; 
//Reutilizar UtilesToString en ToString() (mostrar todos los valores).
namespace Entidades.SP
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {

        public ConsoleColor color;
        public ETipoTrazo trazo;
        public override bool PreciosCuidados
        {
            get
            {
                return true;
            }
        }

        public string Path
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }

        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio) : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public Lapiz() : base("", 0)
        {
        }

        protected override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lapiz");
            sb.AppendLine(base.UtilesToString());
            sb.AppendLine("Color: " + this.color);
            sb.Append("Tipo de trazo: " + this.trazo);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }

        public bool Xml()
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter(Path + @"\Sopelana.Marcos.lapiz.xml"));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lapiz));
                xmlSerializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        bool IDeserializa.Xml(out Lapiz lapiz)
        {
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(Path + @"\Sopelana.Marcos.lapiz.xml");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Lapiz));
                lapiz = (Lapiz)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                return true;
            }
            catch
            {
                lapiz = null;
                return false;
            }
        }
    }
}
