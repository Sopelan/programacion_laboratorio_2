using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que use el operador condicional para dar a una variable llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el usuario son iguales, o "false" si son distintos. 
namespace ejercicio_3._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool iguales;
            int num1;
            int num2;

            Console.WriteLine("ingrese numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            iguales = num1 == num2;
            if (iguales)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son distintos");
            Console.Read();

        }
    }
}
