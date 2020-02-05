using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida al usuario varios números, los vaya añadiendo a un array, mantenga el array ordenado continuamente y muestre el resultado tras añadir cada nuevo dato. Terminará cuando el usuario teclee "fin"
namespace ejercicio_4._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int numero;
            int num;
            bool flag;
            do
            {
                Console.WriteLine("ingrese el numero {0}", numeros.Count + 1);
                flag = int.TryParse(Console.ReadLine(), out num);
                if (flag == false)
                    break;
                numeros.Add(num);
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
        }
    }
}
