using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que pida al usuario un número enteros y diga si es múltiplo de 2 o de 3. 
namespace ejercicio_2._1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("es un multiplo de 2");
            if (num % 3 == 0) Console.WriteLine("es un multiplo de 3");
            Console.Read();
        }
    }
}
