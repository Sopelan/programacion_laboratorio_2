using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crea un programa que pida al usuario que teclee cuatro letras y las muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles. Por ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola"*/
namespace ejercicio_3._3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra1;
            char letra2;
            char letra3;
            char letra4;
            Console.WriteLine("ingrese letra 1");
            letra1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ingrese letra 2");
            letra2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ingrese letra 3");
            letra3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ingrese letra 4");
            letra4 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\"{3}{2}{1}{0}\"",letra1,letra2,letra3,letra4);
            Console.Read();
        }
    }
}
