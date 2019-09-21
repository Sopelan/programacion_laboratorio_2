using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa que calcule un número elevado a otro, usando multiplicaciones sucesivas. 
namespace ejercicio_2._8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            num = num * num;
            Console.WriteLine("el numero multiplicado por si mismo es " + num);
            Console.Read();
        }
    }
}
