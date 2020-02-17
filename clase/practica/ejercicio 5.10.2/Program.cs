using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Como alternativa, crear una función que calcule el valor de elevar un número entero a otro número entero de forma NO recursiva (lo que llamaremos "de forma iterativa"), usando la orden "for". 
namespace ejercicio_5._10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(5, 3));
            Console.ReadLine();
        }
        static int Fact(int num, int potencia)
        {
            int numero = 1;
            for (int i = 1;i <= potencia;i++)
            {
                numero = numero * num;
            }
            return numero;
        }
    }
}
