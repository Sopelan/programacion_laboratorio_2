using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola mundo");
            string nombre = "marcos sopelana";
            int edad = 18;
            nombre = Console.ReadLine();
            Console.WriteLine("mi nombre es {0} y tengo {1}",nombre,edad);
            Console.Read();
        }
    }
}
