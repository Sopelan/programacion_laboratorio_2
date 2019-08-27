using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del
segundo (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b  == 0). */
namespace ejercicio_2._1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Ingresar el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 % num2 == 0) Console.WriteLine("es multiplo");
            else Console.WriteLine("no es multiplo");
            Console.Read();
        }
    }
}
