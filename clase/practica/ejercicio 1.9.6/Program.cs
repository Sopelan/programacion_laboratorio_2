using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crea un programa que convierta de grados Celsius(centígrados) a Kelvin y a Fahrenheit: pedirá al usuario la cantidad de grados centígrados y usará las siguiente tablas de 
 * conversión: kelvin = celsius + 273   ;  fahrenheit = celsius x 18 / 10 + 32 */
namespace ejercicio_1._9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            int Kelvin;
            float Fahrenheit;
            Console.WriteLine("ingrese la cantidad de grados centigrados");
            celsius = Convert.ToInt32(Console.ReadLine());
            Kelvin = celsius + 273;
            Fahrenheit = celsius * 18 / 10f + 32;
            Console.WriteLine("celsius {0}\nkelvin {1}\nfahrenheit {2}", celsius, Kelvin, Fahrenheit);
            Console.Read();
        }
    }
}
