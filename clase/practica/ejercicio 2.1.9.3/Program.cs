using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Repetir el ejercicio 2.1.9.1, empleando "if" en lugar de "switch". 
namespace ejercicio_2._1._9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("eligi una letra");
            letra = Convert.ToChar(Console.ReadLine());
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                Console.WriteLine("es una vocal");
            else if (letra >= '0' && letra <= '9')
                Console.WriteLine("es un numero");
            else if (letra > 'a' || letra > 'e' || letra > 'i' || letra > 'o' || letra > 'u')
                Console.WriteLine("es una consonante");
            else
                Console.WriteLine("no es una vocal o un numero ni una consonante");
            Console.Read();
        }
    }
}
