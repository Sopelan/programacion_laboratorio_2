using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hallar las soluciones de una ecuación de segundo grado del tipo y = Ax2 + Bx + C. Pista: la raíz cuadrada de un número x se calcula 
//con Math.Sqrt(x)
namespace ejercicio_3._2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            double resultadoMas;
            double resultadoMenos;
            double primerResultado;
            double segundoResultado;

            Console.WriteLine("cual es a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cual es b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cual es c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = {0}x2 +{1}x + {2}", a, b, c);
            segundoResultado = (b * b) - (4 * c * a);
            primerResultado = Math.Sqrt(segundoResultado);
            resultadoMas = (0 - b + primerResultado) / (2 * a);
            resultadoMenos = (0 - b - primerResultado) / (2 * a);
            Console.WriteLine("el resultado de la ecuacion y = {0}x2 +{1}x + {2}  y el resultado es en mas es {3} y en menos es {4}", a, b, c, resultadoMas, resultadoMenos);
            Console.Read();
          

        }
    }
}
