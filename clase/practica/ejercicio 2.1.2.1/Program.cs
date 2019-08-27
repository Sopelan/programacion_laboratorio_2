using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que pida al usuario un número entero. Si es múltiplo de 10, se lo avisará al
usuario y pedirá un segundo número, para decir a continuación si este segundo número también es 
múltiplo de 10. */
namespace ejercicio_2._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1 % 10 == 0)
            {
                Console.WriteLine("es un multiplo de 10");
                Console.WriteLine("ingrese otro numero");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 % 10 == 0) Console.WriteLine("es un multiplo de 10");
            }
            Console.Read();
        
        }
    }
}
