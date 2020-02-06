using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crear una función "escribirTablaMultiplicar", que reciba como parámetro un número entero, y escriba la tabla de multiplicar de ese número (por ejemplo, para el 3 deberá llegar desde "3x0=0" hasta "3x10=30"). 
namespace ejercicio_5._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribirTablaMultiplicar(int.MaxValue);
            Console.ReadLine();
        }
        static void EscribirTablaMultiplicar(int num)
        {
            for (int i = 0; i <= 10;i++)
                Console.WriteLine("{0}*{1}={2}", num, i, num * i);
        }
    }
}
