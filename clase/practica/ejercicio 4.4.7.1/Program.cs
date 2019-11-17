using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario cinco frases, las guarde en un array y muestre la "mayor" de ellas (la que aparecería en último lugar en un diccionario). 
namespace ejercicio_4._4._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frases = new string[5];
            string mayor = string.Empty;
            for(int i = 0; i< 5; i++)
            {
                Console.WriteLine("ingrese la frase {0}", i + 1);
                frases[i] = Console.ReadLine();
                if(string.Compare(frases[i],mayor, true) > 0)
                {
                    mayor = frases[i];
                }
            }
            Console.WriteLine("la frase mayor es: " + mayor);
            Console.ReadLine();
        }
    }
}
