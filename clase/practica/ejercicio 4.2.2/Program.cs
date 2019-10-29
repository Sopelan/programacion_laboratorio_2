using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un programa que pida al usuario dos bloques de 6 cadenas de texto. Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno de los dos bloques de información anteriores*/
namespace ejercicio_4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nombres = new string[2, 6];
            string nombre;
            bool flag = false;
            for(int i = 0; i< 2; i++)
            {
                for(int j = 0; j < 6;j++)
                {
                    Console.WriteLine("ingresar el nombre {0}", (i * 6) + 1 + j);
                    nombres[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; i < 6; j++)
                {
                    if (nombre == nombres[i, j])
                    {
                        flag = true;
                        break;
                        
                    }
                   
                }
                if (flag == true)
                    break;
            }
            if (flag == true)
                Console.WriteLine("existe");
            else
                Console.WriteLine("no existe");
            Console.ReadLine();
        }
    }
}
