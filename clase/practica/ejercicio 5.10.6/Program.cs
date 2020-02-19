using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que emplee recursividad para dar la vuelta a una cadena de caracteres (por ejemplo, a partir de "Hola" devolvería "aloH").
namespace ejercicio_5._10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string alReves = Recursividad("hola", 3);
            Console.WriteLine("hola al revez es: " + alReves);
            Console.ReadLine();
        }
        static string Recursividad(string cadena,int i)
        {
            if (i >= 0)
                return cadena[i] + Recursividad(cadena,i -1 );
            return "";
        }
    }
}
