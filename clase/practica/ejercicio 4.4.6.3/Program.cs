using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario una frase y muestre sus palabras en orden inverso. 
namespace ejercicio_4._4._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("ingrese la frase");
            frase = Console.ReadLine();
            string[] frases = frase.Split(' ');
            for(int i = frases.Length - 1;i >= 0;i--)
            {
                Console.WriteLine(frases[i]);
            }
            Console.Read();
        }
    }
}
