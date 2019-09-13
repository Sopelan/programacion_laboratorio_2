using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que muestre los números del 15 al 5, descendiendo (pista: en cada pasada habrá que descontar 1, por ejemplo haciendo i=i-1, que se puede abreviar i--). 
namespace ejercicio_2._2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 15; i >= 5; i--)
                Console.WriteLine(i);
            Console.Read();
        }
    }
}
