using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10). */
namespace ejercicio_2._2._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            int i = 0;
            Console.WriteLine("ingrese numero");
            num = Convert.ToInt32(Console.ReadLine());
            num2 = num;
            while (num2 >= 1)
            {
                num2 = num2 / 10;
                i++;
            }
            if (num == 0)
                i = 1;
            Console.WriteLine("el numero es {0} y tiene {1} ", num,i);
            Console.Read();
        }
    }
}
