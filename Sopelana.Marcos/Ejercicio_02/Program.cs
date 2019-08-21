using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";
            int num;
            int cuadradoNumero;
            int cuboNumero;
            Console.WriteLine("ingresar un numero");
            while (true)
            {
                num = int.Parse(Console.ReadLine());
                if(num > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR ¡reingresar el numero!");
                }
            }
            cuadradoNumero = num * num;
            cuboNumero = cuadradoNumero * num;
            Console.WriteLine("el cuadrado del numero {0} es {1}", num, cuadradoNumero);
            Console.WriteLine("el cubo del numero {0} es {1}", num, cuboNumero);
            Console.Read();

        }
    }
}
