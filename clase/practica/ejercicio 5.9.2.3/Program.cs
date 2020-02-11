using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Haz un programa que pida al usuario 5 datos numéricos, los guarde en un array, pida un nuevo dato y muestre el valor del array que se encuentra más cerca de ese dato, siendo mayor que él. 
namespace ejercicio_5._9._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            bool flag;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1));
                flag = int.TryParse(Console.ReadLine(), out num[i]);
                while (flag == false)
                {
                    Console.WriteLine("Error!!!! Ingrese el numero " + i + 1);
                    flag = int.TryParse(Console.ReadLine(), out num[i]);
                }
            }
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 5; j++)
                    if (num[i] > num[j])
                    {
                        int n = num[i];
                        num[i] = num[j];
                        num[j] = n;
                    }
            Console.WriteLine("Ingrese el numero a buscar");
            flag = int.TryParse(Console.ReadLine(), out int buscar);
            while (flag == false)
            {
                Console.WriteLine("Error!!!! Ingrese el numero a buscar ");
                flag = int.TryParse(Console.ReadLine(), out buscar);
            }
            for (int i = 0; i < 5; i++)
                if(buscar <= num[i])
                {
                    Console.WriteLine("Se encontro y es " + num[i]);
                    break;
                }
                   
            Console.ReadLine();
        }
    }
}
