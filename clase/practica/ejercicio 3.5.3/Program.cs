using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que use el operador condicional para dar a una variable llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por el usuario son pares, o "false" si alguno es impar.  
namespace ejercicio_3._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ambosPares;
            int num1;
            int num2;
            Console.WriteLine("ingrese numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            ambosPares = num1 % 2 == 0 && num2 % 2 == 0;
            if (ambosPares)
                Console.WriteLine("Son pares");
            else
                Console.WriteLine("Son impares");
            Console.Read();
        }
    }
}
