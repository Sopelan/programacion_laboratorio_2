using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Multiplicar dos números tecleados por usuario. El programa deberá contener un comentario al principio, que recuerde cual es su objetivo. */
namespace ejercicio_1._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int producto;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            producto = num1 * num2;
            Console.WriteLine("el producto de {0} y {1} es {2}",num1,num2,producto);
            Console.ReadLine();
        }
    }
}
