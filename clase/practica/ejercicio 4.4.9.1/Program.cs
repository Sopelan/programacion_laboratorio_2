using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario una frase y la descomponga en subcadenas separadas por espacios, usando "Split". Luego debe mostrar cada subcadena en una línea nueva, usando "foreach". 
namespace ejercicio_4._4._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string[] frases;
            Console.WriteLine("ingresar la frase");
            frase = Console.ReadLine();
            frases = frase.Split(',');
            foreach(string s in frases)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
