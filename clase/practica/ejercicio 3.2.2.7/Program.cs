using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Escribe un programa que calcule una aproximación de PI mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... 
 El usuario deberá indicar la cantidad de términos a utilizar, y el programa mostrará todos los resultados hasta esa cantidad de términos */
namespace ejercicio_3._2._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double suma = 0;
            int j = 1;
            Console.WriteLine("ingrese terminos");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i += 1)
            {
                if (i % 2 == 1)
                {
                    suma += (1f / j);
                }
                else
                {
                    suma -= (1f / j);
                }
               j += 2;
            }
            Console.WriteLine(suma * 4);
            Console.WriteLine(Math.PI);
            Console.Read();

        }
    }
}
