using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear el diagrama de flujo para el programa que pide tres números al usuario y dice cuál es el mayor de los tres. 
namespace ejercicio_2._1._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("ingrese numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3))
                Console.WriteLine("el numero mas grande es el num1");
            else if ((num2 > num3) && (num2 > num1))
                Console.WriteLine("el numero mas grande es el num2");
            else if ((num3 > num1) && (num3 > num2))
                Console.WriteLine("el numero mas grande es el num3");
            else
                Console.WriteLine("no hay numero grande");
            Console.Read();
        }  
    }
}
