using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Crear el diagrama de flujo para el programa que pide al usuario dos números y dice si uno de ellos es positivo, si lo son los dos o si no lo es ninguno.*/
namespace ejercicio_2._1._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;
            Console.WriteLine("ingresar el primer numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresar el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            if ((num >= 0) && (num2 >= 0))
                Console.WriteLine("los dos son positivos");
            else if ((num >= 0) || (num2 >= 0))
                Console.WriteLine("uno de ellos es positivo");
            else
                Console.WriteLine("ninguno es positivo");
            Console.ReadLine();
            

        }
    }
}
