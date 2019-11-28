using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace ENTIDADES.SP
{
    public class Manzana : Fruta , ISerializar , IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Manzana";    
            }
        }
        protected override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Manzana():base()
        {
            this._provinciaOrigen = "";
        }

        public Manzana(string color, double peso , string provinciaOrigen) : base(color, peso)
        {
            this._provinciaOrigen = provinciaOrigen;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre de la fruta: " + this.Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Provincia de origen: " + this._provinciaOrigen);
            sb.Append("Tiene carozo? " + this.TieneCarozo);
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                TextWriter streamWriter = new StreamWriter(@"D:\VisualStudio\programacion_laboratorio_2\" + path);
                xml.Serialize(streamWriter, this);
                Console.WriteLine(this.ToString());
                streamWriter.Close();
                return true;
            }

            catch (Exception exception)
            {
                
                return false;
            }
        }

        bool IDeserializar.Xml(string path, out Fruta fruta)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Manzana));
                TextReader textReader = new StreamReader(@"D:\VisualStudio\programacion_laboratorio_2\" + path);
                fruta = (Manzana)xml.Deserialize(textReader);
                
                textReader.Close();
                return true;
            }
            catch (Exception exception)
            {
                
                fruta = null;
                return false;
            }
        }
    }
}
