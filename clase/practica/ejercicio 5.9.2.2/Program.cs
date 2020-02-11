using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Haz un programa que resuelva ecuaciones de segundo grado, del tipo ax2 + bx + c = 0. El usuario deberá introducir los valores de a, b y c. Se deberá crear una función "raicesSegundoGrado", que recibirá como parámetros los coeficientes a, b y c, 
   así como las soluciones x1 y x2 (por referencia). Deberá devolver los valores de las dos soluciones x1 y x2. Si alguna solución no existe, se devolverá como valor 100.000 para esa solución. Pista: la solución se calcula con x = -b  raíz (b2 – 4·a·c)  / 2·a */
namespace ejercicio_5._9._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = new double();
            double x2 = new double();
            Console.WriteLine("ecuaciones de segundo grado(ax2 + bx + c = 0)");
            Console.WriteLine("ingrese la A");
            bool flag = int.TryParse(Console.ReadLine(), out int a);
            while (flag == false)
            {
                Console.WriteLine("Error!!! ingrese la A");
                flag = int.TryParse(Console.ReadLine(), out a);
            }
            Console.WriteLine("ingrese la b");
            flag = int.TryParse(Console.ReadLine(), out int b);
            while (flag == false)
            {
                Console.WriteLine("Error!!! ingrese la b");
                flag = int.TryParse(Console.ReadLine(), out b);
            }
            Console.WriteLine("ingrese la c");
            flag = int.TryParse(Console.ReadLine(), out int c);
            while (flag == false)
            {
                Console.WriteLine("Error!!! ingrese la c");
                flag = int.TryParse(Console.ReadLine(), out c);
            }
            RaicesSegundoGrado(a, b, c, ref x1, ref x2);
            Console.WriteLine("La raiz de segundo grado de {0}x2 + {1}x + {2} = 0", a, b, c);
            Console.WriteLine("La x1 es " + x1);
            Console.WriteLine("la x2 es " + x2);
            Console.ReadLine();

        }
        static void RaicesSegundoGrado(int a, int b,int c,ref double x1,ref double x2)
        {
            double resultado1 = (b * b) - (4 * a * c);
            if (resultado1 < 0 )
            {
                x2 = 100000;
                x1 = 100000;
            }
            else
            {
                double resultado2 = Math.Sqrt(resultado1);
                try
                {
                    x1 = (-b + resultado2) / (2 * a);
                }
                catch
                {
                    x1 = 100000;
                }
                try
                {
                    x2 = (-b - resultado2) / (2 * a);
                }
                catch
                {
                    x2 = 100000;
                }
            }
            
        }
    }
}
