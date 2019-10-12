using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* El usuario de nuestro programa podrá teclear dos números de hasta 12 cifras significativas. El programa deberá mostrar el resultado 
de dividir el primer número entre el segundo, utilizando tres cifras decimales.*/
namespace ejercicio_3._2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float resultado;
            Console.WriteLine("ingrese el num1");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el num2");
            num2 = float.Parse(Console.ReadLine());
            resultado = num1 / num2;
            Console.WriteLine("el numero es {0}", resultado.ToString("#.##"));
            Console.Read();
        }
    }
}
