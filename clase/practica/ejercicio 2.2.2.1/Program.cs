using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).
namespace ejercicio_2._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;

            do
            {
                Console.WriteLine("ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
            } while (num > 0);
            Console.WriteLine("la suma es " + suma);
            Console.Read();
        }
    }
}
