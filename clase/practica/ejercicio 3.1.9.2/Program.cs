using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pedir al usuario dos números de dos cifras ("byte"), calcular su multiplicación, que se deberá guardar en un "ushort", y mostrar el resultado en pantalla. 
namespace ejercicio_3._1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num1;
            byte num2;
            ushort multiplicacion;
            Console.WriteLine("ingrese el numero 1");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            num2 = Convert.ToByte(Console.ReadLine());
            multiplicacion = Convert.ToUInt16( num1 * num2);
            Console.WriteLine("numero {0} * numero {1} = {2}", num1, num2, multiplicacion);
            Console.Read();
        }
    }
}
