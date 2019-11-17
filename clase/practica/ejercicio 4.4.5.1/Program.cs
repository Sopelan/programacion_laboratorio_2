using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un programa que pida al usuario 10 frases, las guarde en un array, y luego le pregunte textos de forma repetitiva, e indique si cada uno de esos textos aparece como parte de alguno de los elementos del array. Terminará cuando el texto introducido sea "fin". */
namespace ejercicio_4._4._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frases = new string[10];
            string buscar;
            bool flag = false;
            for (int i = 0; i < frases.Length; i++)
            {
                Console.WriteLine("escribi la frase {0}", i + 1);
                frases[i] = Console.ReadLine();
            }
            do
            {
                Console.WriteLine("ingrese la frase al buscar");
                buscar = Console.ReadLine();
                foreach (string frase in frases)
                {
                    if (frase.IndexOf(buscar) >= 0)
                    {
                        Console.WriteLine("existe la frase " + frase);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    Console.WriteLine("no existe la frase " + buscar);
            } while (buscar != "fin");

        }
    }
}
