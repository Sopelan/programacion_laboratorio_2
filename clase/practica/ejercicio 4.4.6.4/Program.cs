using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario varios números separados por espacios y muestre su suma
namespace ejercicio_4._4._6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeros;
            string[] numero;
            int suma = new int();
            Console.WriteLine("ingrese los numeros");
            numeros = Console.ReadLine();
            numero = numeros.Split(' ');
            foreach (string number in numero)
            {
                suma += Convert.ToInt32(number);
            }
            Console.WriteLine("La suma entre {0} es {1}", numeros, suma);
            Console.ReadLine();
        }
    }
}
