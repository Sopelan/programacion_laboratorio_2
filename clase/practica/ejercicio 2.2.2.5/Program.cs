using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa que pida al usuario su identificador y su contraseña, y no le permita seguir hasta que introduzca como nombre "Pedro" y como contraseña "Peter".
namespace ejercicio_2._2._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ind;
            string con;
            do
            {
                Console.WriteLine("Ingrese su identificador");
                ind = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                con = Console.ReadLine();
            } while (ind != "Pedro" || con != "Peter");
            Console.WriteLine("Identificador correcto y contraseña correctos");
            Console.Read();
        }
    }
}
