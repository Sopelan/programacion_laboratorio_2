using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ampliar el ejercicio anterior, para añadir una segunda fase en la que el usuario pueda "preguntar" si un cierto valor está en el array.Como el array está ordenado, la búsqueda no se hará hasta el final de los datos, sino hasta que se encuentre el dato buscado o un un dato mayor que él.
namespace ejercicio_4._6._4
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
            while(flag2 == false)
            {
                Console.WriteLine("que numero desea buscar?");
                flag2 = int.TryParse(Console.ReadLine(),out num);
            }
            for(int i = 0; i< numeros.Count; i++)
            {
                if(numeros[i] >= num)
                {
                    Console.WriteLine("Se encontro y es " + numeros[i]);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
