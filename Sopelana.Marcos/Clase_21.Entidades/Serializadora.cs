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
            return xml.Guardar(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\Sopelana.Marcos\Lista de personas.xml");
        }
        public static bool Deserializar(IXml xml , out object obj)
        {
            return xml.Leer(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\Sopelana.Marcos\Lista de personas.xml",  out obj);
        }
    }
}
