using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos. 
namespace ejercicio_2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2) Console.WriteLine("el numero 1 es mayor");
            else if (num1 == num2) Console.WriteLine("los dos numeros son iguales");
            else Console.WriteLine("el numero 2 es mayor");
            Console.Read();
            
        }
    }
}
