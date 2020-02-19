using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear un programa que emplee recursividad para calcular la suma de los elementos de un vector. 
namespace ejercicio_5._10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 1, 2, 3, 4 };
            int total = Recursividad(num, 0);
            Console.WriteLine("la suma del vector es: " + total);
            Console.ReadLine();
        }
        static int Recursividad(int[] num , int i)
        {
            if(i <num.Length)
                return num[i] + Recursividad(num, i + 1);
            return 0;
        }
    }
}
