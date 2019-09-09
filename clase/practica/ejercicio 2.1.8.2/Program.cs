using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Usar el operador condicional para calcular el menor de dos números. 
namespace ejercicio_2._1._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int condiccion;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            condiccion = (num1 < num2) ? num1 : num2;
            Console.WriteLine("el numero mas chico es " + condiccion);
            Console.Read();
        }
    }
}
