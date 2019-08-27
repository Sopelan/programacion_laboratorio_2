using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará
el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es
cero, escribirá "Error: No se puede dividir entre cero". */
namespace ejercicio_2._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            float dividir;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                dividir = (float)num1 / num2;
                Console.WriteLine("la division de {0} entre {1} es {2}", num1, num2, dividir);
            }
            else Console.WriteLine("Error no se puede dividir entre cero");
            Console.Read();
        }
       
    }
}
