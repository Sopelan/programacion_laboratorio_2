using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Clase_21.Entidades;
/*Crear List<Persona>
 * Agregar: Personas,Empleados y Alumnos
 * Serializar la lista
 * Observar contenido del archivo.xml
 * deserializar la lista*/
namespace Clase_21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona("marcos" , "sopelana",20),
                new Empleado("mariano","sopelana",41,40023232,30000),
                new Alumno("silvina","dorrego",41,10)
            };
            //try
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(Persona));
            //    TextWriter streamWriter = new StreamWriter(@"D:\VisualStudio\Sopelana.Marcos\texto.xml");
            //    Persona persona = new Persona("juan", "perez" , 18);
            //    xml.Serialize(streamWriter, persona);
            //    Console.WriteLine(persona.ToString());
            //    streamWriter.Close();
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //try
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(Persona));
            //    TextReader textReader = new StreamReader(@"D:\VisualStudio\Sopelana.Marcos\texto.xml");
            //    Persona persona = (Persona)xml.Deserialize(textReader);
            //    textReader.Close();
            //    Console.WriteLine(persona.ToString());
                
            //}
            //catch(Exception exception)
            //{
            //    Console.WriteLine(exception.Message);

            //}

            //try
            //{
            //    List<Persona> personas = new List<Persona>
            //    {
            //        new Persona("juan", "perez", 20),
            //        new Persona("ricardo", "perez", 23),
            //        new Persona("eberto", "perez", 25),
            //        new Persona("martin", "beñites", 24),
            //        new Persona("juan", "campaña", 22)
            //    };
            //    XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
            //    TextWriter streamWriter = new StreamWriter(@"D:\VisualStudio\Sopelana.Marcos\Lista de personas.xml");
            //    xml.Serialize(streamWriter, personas);
            //    streamWriter.Close();
            //}
            //catch(Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            
            Console.ReadLine();
            
        }
    }
}
