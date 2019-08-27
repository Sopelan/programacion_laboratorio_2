using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que pida al usuario un número entero y diga si es par(pista: habrá que 
 comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …)*/
namespace ejercicio_2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduce un numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("Es par");
            else Console.WriteLine("No es par");
            Console.Read();
        }
    }
}
