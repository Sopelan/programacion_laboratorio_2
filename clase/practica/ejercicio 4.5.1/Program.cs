using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida el nombre, el apellido y la edad de una persona, los almacene en un "struct" y luego muestre los tres datos en una misma línea, separados por comas.
namespace ejercicio_4._5._1
{
    class Program
    {
        public struct Persona
        {
            public string nombre;
            public string apellido;
            public int edad;
        }
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("ingrese tu nombre");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("ingrese tu apellido");
            persona.apellido = Console.ReadLine();
            try
            {
                Console.WriteLine("ingrese tu edad");
                persona.edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0},{1},{2}", persona.apellido, persona.nombre, persona.edad);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
