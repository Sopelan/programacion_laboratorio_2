using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es
 positivo", "Los dos números son positivos" o bien "Ninguno de los números es positivo", según
 corresponda.*/
namespace ejercicio_2._1._5._2
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
            if ((num1 > 0) && (num2 > 0)) Console.WriteLine("Los dos numeros son positivos");
            else if ((num1 > 0) || (num2 > 0))
                Console.WriteLine("Uno de los numeros es positivos");
            else Console.WriteLine("Ninguno de los numeros es positivo");
            Console.Read();
        }
    }
}
