using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Juan", o bien le diga "No te conozco" si teclea otro nombre. 
namespace ejercicio_3._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            if (nombre == "Juan")
                Console.WriteLine("Hola {0}", nombre);
            else
                Console.WriteLine("No te conozco");
            Console.ReadLine();
        }
    }
}
