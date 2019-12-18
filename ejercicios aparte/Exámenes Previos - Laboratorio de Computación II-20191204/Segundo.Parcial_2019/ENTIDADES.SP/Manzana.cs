using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
//Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
namespace ENTIDADES.SP
{
    public class Manzana : Fruta ,ISerializar,IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Manzana";
            }
        }
        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public string ProvinciaOrigen { get => _provinciaOrigen; set => _provinciaOrigen = value; }

        public Manzana()
        {

        }
        public Manzana(string color, double peso , string provinciaOrigen) : base(color, peso)
        {
            this.ProvinciaOrigen = provinciaOrigen;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Provincia de Origen: " + this.ProvinciaOrigen);
            sb.Append("Tiene carozo? " + this.TieneCarozo);
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                xmlSerializer.Serialize(xmlTextWriter, this);
                xmlTextWriter.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        bool IDeserializar.Xml(string path, out Fruta fruta)
        {
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                fruta = (Manzana)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                return true;
            }
            catch
            {
                fruta = null;
                return false;
            }
        }
    }
}
