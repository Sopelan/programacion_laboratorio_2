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
    public static class Serializadora
    {
        public static bool Serializar(IXml xml)
        {
            return xml.Guardar("");
        }
        public static bool Deserializar(IXml xml , out object obj)
        {
            return xml.Leer(" ",  out obj);
        }
    }
}
