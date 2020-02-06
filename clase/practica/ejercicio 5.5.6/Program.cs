using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función que reciba una letra y un número, y escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha indicado. Por ejemplo, si la letra es * y la anchura es 4, debería escribir **** *** ** * 
namespace ejercicio_5._5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo('*',4);
            Console.ReadLine();
        }
        static void Triangulo(char letra,int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                for (int j = numero - i; j < numero; j++)
                {
                    Console.Write(letra);
                }
                Console.WriteLine();
            }
        }
    }
}
