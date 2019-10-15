using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crea un programa que pida números binarios al usuario y muestre su equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el usuario introduzca la palabra "fin". */
namespace ejercicio_3._2._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            while (true) 
            {
                Console.WriteLine("ingrese un numero");
                binario = Console.ReadLine();
                if(binario == "fin")
                {
                    break;
                }
                Console.WriteLine("el numero en decimal: " + Convert.ToInt32(binario, 2));
                Console.WriteLine("el numero en xexadecimal: " + Convert.ToString(Convert.ToInt32(binario, 2), 16));

            } 
        }
    }
}
