using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea un programa que muestre los valores de la función y = 10 * seno(x*5), para valores de x entre 0 y 72 grados. Recuerda que las funciones trigonométricas esperan que el ángulo se indique en radianes, no en grados. La equivalencia es que 360 grados son 2*PI radianes. 
namespace ejercicio_5._9._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double grado = new Random().Next(0, 72);
            double multiplica = Math.PI * 2 / 360;
            double x = grado * multiplica;
            double resultado = 10 * Math.Sin(x * 5);
            Console.WriteLine("grado :" + grado);
            Console.WriteLine("multiplica: " + multiplica);
            Console.WriteLine("10 * seno({0}*5) : {1}", x, resultado);
            Console.ReadLine();
        }
    }
}
