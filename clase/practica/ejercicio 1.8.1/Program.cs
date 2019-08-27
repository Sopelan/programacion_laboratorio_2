using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea un programa que calcule el producto de dos números introducidos por el usuario. 
namespace ejercicio_1._8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int producto;
            Console.WriteLine("ingrese el primer Numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo Numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            producto = primerNumero * segundoNumero;
            Console.WriteLine("el producto de {0} y {1} es {2}",primerNumero , segundoNumero, producto);
            Console.Read();
        }
    }
}
