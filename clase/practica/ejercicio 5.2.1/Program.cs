using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 25 líneas en blanco. No debe devolver ningún valor. Crea también un "Main" que permita probarla.
namespace ejercicio_5._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doctor stone vieja");
            Console.ReadLine();
            BorrarPantalla();
            Console.ReadLine();
        }
        static void BorrarPantalla() 
        {
            Console.Clear();
            for(int i = 0; i<25;i++)
            {
                Console.WriteLine();
            }
        }
    }
}
