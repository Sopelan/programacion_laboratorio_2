using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que emplee recursividad para calcular el mayor de los elementos de un vector
namespace ejercicio_5._10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 10, 2, 34, 23, 4 };
            int mayor = Recursividad(num, 0);
            Console.WriteLine("el mayor del vector es: " + mayor);
            Console.ReadLine();
        }
        static int Recursividad(int[] num, int i)
        {
            int mayor;
            if (num.Length > i)
            {

                mayor = Recursividad(num, i + 1);
                if (mayor > num[i])
                    return mayor;
                else
                    return num[i];
            }
            return int.MinValue;

        }
    }
}
