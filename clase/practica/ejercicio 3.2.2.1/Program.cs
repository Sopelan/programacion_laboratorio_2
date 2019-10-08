using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Calcular el área de un círculo, dado su radio (pi * radio al cuadrado)
namespace ejercicio_3._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio;
            double area;
            Console.WriteLine("ingrese el radio de un circulo");
            radio = Convert.ToInt32(Console.ReadLine());
            area = radio * Math.PI * radio;
            Console.WriteLine("El area es " + area);
            Console.ReadLine();
        }
    }
}
