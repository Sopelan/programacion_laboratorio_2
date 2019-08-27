using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per;
            string nombreCompleto;
            per = new Persona("marcos", "sopelana", 42942313);
            //per.nombre = "marcos";
            //per.apellido = "sopelana";
            //per.dni = 42942313;
            nombreCompleto = per.mostrar();
            Console.WriteLine(nombreCompleto);
            Persona per2;
            string nombreCompleto2;
            per2 = new Persona("mariano", "sopelana", 27146653);
            //per2.nombre = "mariano";
            //per2.apellido = "sopelana";
            //per2.dni = 27146653;
            nombreCompleto2 = per2.mostrar();
            Console.WriteLine(nombreCompleto2);
            Console.Read();

        }
    }
}
