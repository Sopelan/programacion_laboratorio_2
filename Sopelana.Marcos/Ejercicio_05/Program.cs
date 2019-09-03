using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista (1 a 8)
 en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas 
 iguales a 595. Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. Nota: Utilizar estructuras repetitivas y selectivas. */
namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma1;
            int suma2;
            int siguiente;
            int i;
            int ultimo;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 2; i <= num; i++)
            {
                suma1 = 0;
                suma2 = 0;
                ultimo = i - 1;
                siguiente = i + 1;
                while (ultimo > 0  )
                {
                    suma1 += ultimo;
                    ultimo--;
                    
                }
                while(suma2 < suma1)
                {
                    suma2 += siguiente;
                    siguiente++;
                }
                if(suma2 == suma1)
                    Console.WriteLine(suma1 + " " + i + " " + suma2);
                    
                
            }
            Console.Read();
        }
    }
}
