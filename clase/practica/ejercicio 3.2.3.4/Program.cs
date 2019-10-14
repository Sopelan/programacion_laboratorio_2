using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Calcular la superficie y el volumen de una esfera, a partir de su radio (superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). Mostrar los resultados con 3 cifras decimales. */
namespace ejercicio_3._2._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double superficie;
            double volumen;
            Console.WriteLine("cual es el radio de tu circulo");
            radio = Convert.ToDouble(Console.ReadLine());
            superficie = 4 * Math.PI * radio * radio;
            volumen = 4 / 3 * Math.PI * radio * radio * radio;
            Console.WriteLine("El radio es: " + radio.ToString("0.00"));
            Console.WriteLine("La superficie es: " + superficie.ToString("0.00"));
            Console.WriteLine("El volumen es: " + volumen.ToString("0.00"));
            Console.Read();
        }
    }
}
