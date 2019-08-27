using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* ) El usuario tecleará dos números (x e y), y el programa deberá calcular cuál es el resultado de su división y el resto de esa división. Deberás usar "Write" en vez de 
 "WriteLine" para pedir los datos, e incluir un comentario con tu nombre y la fecha en que has realizado el programa. */
namespace ejercicio_1._9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int division;
            int resto;
            Console.Write("ingrese el primer numero\n");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el segundo numero\n");
            y = Convert.ToInt32(Console.ReadLine());
            division = x / y;
            resto = x % y;
            Console.Write("la division entre {0} y {1} es {2} con resto {3}", x, y, division, resto);
            Console.ReadLine();
        }
    }
}
