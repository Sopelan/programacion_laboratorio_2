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
    public class Manzana : Fruta , ISerializar , IDeserializar
    {
        public string _provincia;

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

        public Manzana(string color, double peso, string provincia) : base(color, peso)
        {
            this._provincia = provincia;
        }

        public Manzana()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("tiene carozo?: " + this.TieneCarozo);
            sb.Append(this._provincia);
            return sb.ToString();
        }

        bool IDeserializar.Xml(string path, out Fruta fruta)
        {
            try
            {
                XmlTextReader xmlTextReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                fruta = (Manzana)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                fruta = default;
                return false;
            }
        }

        public bool Xml(string path)
        {
            try
            {
                XmlTextWriter xmlTextWriter = new XmlTextWriter(new StreamWriter( Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +  @"\" + path));
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
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
    }
}
