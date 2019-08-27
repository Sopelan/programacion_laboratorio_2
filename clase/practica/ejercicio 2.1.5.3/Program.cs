using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que pida al usuario tres números reales y muestre cuál es el mayor de los
 tres*/
namespace ejercicio_2._1._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());
            if ((num1 > num2) && (num1 > num3)) Console.WriteLine("el mayor es el primero");
            else if ((num2 > num1) && (num2 > num3))
                Console.WriteLine("el mayor es el segundo");
            else if ((num3 > num1) && (num3 > num2)) Console.WriteLine("el mayor es el tercero");
            else Console.WriteLine("no existe el mayor");
            Console.Read();
        }
    }
}
