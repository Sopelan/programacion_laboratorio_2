using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while". 
namespace ejercicio_2._2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 26;
            do
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
                num--;
            } while (num >= 10);
            Console.Read();
        }
    }
}
