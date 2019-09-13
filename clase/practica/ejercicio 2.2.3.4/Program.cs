using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que escriba en pantalla la tabla de multiplicar del 5. 
namespace ejercicio_2._2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine("5 x {0} es {1}", i, i * 5);
            Console.Read();
        }
    }
}
