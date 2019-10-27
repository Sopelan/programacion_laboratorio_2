using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que reserve espacio para un vector de 3 componentes, pida al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) 
 * y muestre su módulo (raíz cuadrada de la suma de sus componentes al cuadrado).*/
namespace ejercicio_4._1._4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double raiz;
            double suma =  new double();
            int[] num = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("ingrese el numero {0}", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
                suma += (num[i] * num[i]);
            }
            raiz = Math.Sqrt(suma);
            Console.WriteLine("El modulo es {0}", raiz);
            Console.Read();
           
        }
    }
}
