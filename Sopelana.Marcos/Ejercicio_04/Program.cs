using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número. El primer número perfecto es 6, ya que los divisores de 6 son 
 * 1, 2 y 3; y 1 + 2 + 3 = 6. Escribir una aplicación que encuentre los 4 primeros números perfectos. Nota: Utilizar estructuras repetitivas y selectivas.  */
namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num = 0;
            int j = 0;
            int resultado;
            Boolean flag = false; 
            for(i = 0; i < 4; i++)
            {
                flag = false;
                while (flag == false)
                {
                    resultado = 0;
                    num++;
                    j = 1;
                    while(num > j)
                    {
                        if(num % j == 0)
                            resultado += j;
                        j++;
                    }
                    if (num == resultado)
                    {
                        flag = true;
                        j = 1;
                    }
                    while((flag == true) && (num > j))
                    {
                        if (num % j == 0)
                            Console.Write(j + " ");
                        
                        j++;
                    }
                   
                }
                Console.WriteLine(num);
               
            }
            Console.ReadLine();
        }
    }
}
