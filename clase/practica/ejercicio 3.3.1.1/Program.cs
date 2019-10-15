using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que pida una letra al usuario y diga si se trata de una vocal
namespace ejercicio_3._3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("ingrese una letra");
            letra = Convert.ToChar(Console.ReadLine());
            if (letra == 'a' || letra == 'i' || letra == 'u' || letra == 'e' || letra == 'o')
                Console.WriteLine("es una vocal");
            else
                Console.WriteLine("no es una vocal");
            Console.Read();
        }
    }
}
