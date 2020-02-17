using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear una función que calcule el valor de elevar un número entero a otro número entero (por ejemplo, 5 elevado a 3 = 53 = 5 ·5 ·5 = 125). Esta función se debe crear de forma recursiva
namespace ejercicio_5._10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(10, 6));
            Console.ReadLine();
            
        }
        static int Fact(int num,int potencia)
        {
            if (potencia == 1)
                return num;
            return num * Fact(num, potencia - 1);
        }
    }
}
