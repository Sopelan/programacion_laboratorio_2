using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar una variante del ejercicio anterior, que en vez de hacer una búsqueda lineal (desde el principio), use "búsqueda binaria": se comenzará a comparar con el punto medio del array; si nuestro dato es menor, se vuelve a probar en el punto medio de la mitad inferior del array, y así sucesivamente
namespace ejercicio_4._6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int numero;
            bool flag;
            do
            {
                Console.WriteLine("ingrese el numero {0}", numeros.Count + 1);
                flag = int.TryParse(Console.ReadLine(), out int nume);
                if (flag == false)
                    break;
                numeros.Add(nume);
                for (int i = 0; i < numeros.Count - 1; i++)
                {
                    for (int j = i + 1; j < numeros.Count; j++)
                    {
                        if (numeros[i] > numeros[j])
                        {
                            numero = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = numero;
                        }
                    }
                }
                Console.WriteLine("lista");
                foreach (int i in numeros)
                    Console.WriteLine(i);
            } while (true);
            int num = 0;
            bool flag2 = false;
            while (flag2 == false)
            {
                Console.WriteLine("que numero desea buscar?");
                flag2 = int.TryParse(Console.ReadLine(), out num);
            }
            int busqueda = numeros.Count / 2;
            while(true)
            {
                Console.WriteLine(busqueda);
                try
                {
                     if (num <= numeros[busqueda])
                     {
                         Console.WriteLine("se emcontro y es " + numeros[busqueda]);
                         break;
                     }
                }
                catch
                {
                    Console.WriteLine("se emcontro y es " + numeros[numeros.Count -1 ]);
                    break;
                }
                
                busqueda = busqueda + (busqueda / 2);
            }
            Console.ReadLine();
        }
    }
}
