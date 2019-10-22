using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que pida al usuario 4 números, los memorice (utilizando una tabla), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados. 
namespace ejercicio_4._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[4];
            int suma = new int();
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el numero {0}",i+1);
                numero[i] = Convert.ToInt32(Console.ReadLine());
                
                suma += numero[i];
            }
            foreach (int num in numero)
                Console.WriteLine("numero: {0}", num);
            Console.WriteLine("la media aritmetica es " + (suma/4f));
            Console.ReadLine();
        }
    }
}
