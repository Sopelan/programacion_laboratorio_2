using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear una función llamada "signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero. 
namespace ejercicio_5._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("el numero 132 es {0}\nel numero -232 es {1}\nel numero 0 es {2}", Signo(132), Signo(-232), Signo(0));
            Console.ReadLine();
        }
        static int Signo(float num)
        {
            if (num > 0)
                return 1;
            else if (num < 0)
                return -1;
            else
                return 0;
        }
    }
}
