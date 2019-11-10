using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que pida una frase al usuario y la muestra en orden inverso (de la última letra a la primera).*/
namespace ejercicio_4._4._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("ingresar la frase");
            frase = Console.ReadLine();
            for(int i = frase.Length - 1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
            Console.ReadLine();
        }
    }
}
