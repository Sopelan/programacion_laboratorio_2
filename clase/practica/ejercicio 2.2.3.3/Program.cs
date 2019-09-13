using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo). 
namespace ejercicio_2._2._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letra = 'Z'; letra >= 'A'; letra--)
                Console.WriteLine(letra);
            Console.Read();
        }
    }
}
