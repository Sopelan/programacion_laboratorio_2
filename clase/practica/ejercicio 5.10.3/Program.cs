using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que emplee recursividad para calcular un número de la serie Fibonacci (en la que los dos primeros elementos valen 1, y para los restantes, cada elemento es la suma de los dos anteriores). 
namespace ejercicio_5._10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<= 10000;i++)
            Console.WriteLine(Fibonacci(i));
            Console.ReadLine();
        }
        static int Fibonacci(int num)
        {
            if (num == 1 || num == 0)
                return 1;
            else
                return Fibonacci(num - 2) + Fibonacci(num - 1);

        }
    }
}
