using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Pedir al usuario un número y mostrar su tabla de multiplicar. Por ejemplo, si el número es el 3, debería escribirse algo como  
3 x 0 = 0 
3 x 1 = 3 
3 x 2 = 6 
… 
3 x 10 = 30 */
namespace ejercicio_1._9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i;
            int producto;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 0;i <= 10;i++)
            {
                producto = num * i;
                Console.WriteLine("{0} * {1} = {2}",num,i,producto);
            }
            Console.Read();
        }
    }
}
