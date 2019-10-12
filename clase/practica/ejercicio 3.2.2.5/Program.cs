using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que muestre los primeros 20 valores de la función y = x2-1 */
namespace ejercicio_3._2._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int x2 = x*x;
            int resultado;
            for (x = 1; x <= 20; x++)
            {
                x2 = x * x;
                resultado = x2 - 1;
                Console.WriteLine(resultado);
            }
            Console.Read();
                
        }
    }
}
