using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Repetir el ejercicio 2.1.9.2, empleando "if" en lugar de "switch". 
namespace ejercicio_2._1._9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("ingrese una letra");
            letra = Convert.ToChar(Console.ReadLine());
            if (letra >= '0' && letra <= '9')
                Console.WriteLine("es un numero");
            else if (letra == '.' || letra == ';' || letra == '.' || letra == ':')
                Console.WriteLine("es un signo de puntuacion");
            else
                Console.WriteLine("es algun otro caracter");
            Console.Read();
    
        }
    }
}
