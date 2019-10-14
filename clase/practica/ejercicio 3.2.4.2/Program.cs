using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que pida al usuario la cantidad de rojo (por ejemplo, 255), verde (por ejemplo, 160) y azul (por ejemplo, 0) que tiene un color, y que muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000) */
namespace ejercicio_3._2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rojo;
            int verde;
            int azul;
            Console.WriteLine("Ingrese la cantidad de rojo");
            rojo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de verde");
            verde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de azul");
            azul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("RGB en notacion hexadecimal: " + Convert.ToString(rojo,16) + Convert.ToString(verde,16) + Convert.ToInt32(Convert.ToString(azul,16)).ToString("00"));
            Console.ReadLine();
        }
    }
}
