using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Haz un programa que pida al usuario 5 datos numéricos, los guarde en un array, pida un nuevo dato y muestre el valor del array que se encuentra más cerca de ese dato en valor absoluto (es decir, el más próximo, sea mayor que él o menor que él)
namespace ejercicio_5._9._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int nuevoDato;
            int num;
            bool flag;
            int comparacion1 = int.MinValue;
            int comparacion2 = int.MaxValue;
            int respuesta;
            int respuesta2;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1));
                flag = int.TryParse(Console.ReadLine(), out numeros[i]);
                while (flag == false)
                {
                    Console.WriteLine("Error!!!! Ingrese el numero " + (i + 1));
                    flag = int.TryParse(Console.ReadLine(), out numeros[i]);
                }
            }
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 5; j++)
                    if (numeros[i] > numeros[j])
                    {
                        num = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = num;
                    }
            Console.WriteLine("Ingrese el numero a buscar");
            flag = int.TryParse(Console.ReadLine(), out nuevoDato);
            while (flag == false)
            {
                Console.WriteLine("Error!!!! Ingrese el numero a buscar ");
                flag = int.TryParse(Console.ReadLine(), out nuevoDato);
            }
            for (int i = 0; i < 5; i++)
                if (nuevoDato <= numeros[i])
                {
                    comparacion1 = numeros[i];
                    break;
                }
            for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 5; j++)
                    if (numeros[i] < numeros[j])
                    {
                        num = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = num;
                    }
            for (int i = 0; i < 5; i++)
                if (nuevoDato >= numeros[i])
                {
                    comparacion2 = numeros[i];
                    break;
                }
            if (comparacion1 == comparacion2)
                Console.WriteLine("El numero se encontro y es {0} y {1}", comparacion1, comparacion2);
            else
            {
                if (comparacion1 == int.MinValue)
                {
                    respuesta2 = nuevoDato - comparacion2;
                    Console.WriteLine("el numero mas 2cercano es " + comparacion2);
                }
                else if (comparacion2 == int.MaxValue)
                {
                    respuesta = comparacion1 - nuevoDato;
                    Console.WriteLine("el numero mas 1cercano es " + comparacion1);
                }
                else
                {
                    respuesta = comparacion1 - nuevoDato;
                    respuesta2 = nuevoDato - comparacion2;
                    if (respuesta > respuesta2)
                        Console.WriteLine("el numero mas 2cercano es " + comparacion2);
                    else if (respuesta < respuesta2)
                        Console.WriteLine("el numero mas 1cercano es " + comparacion1);
                    else
                        Console.WriteLine("los dos numeros son cercanos: {0} y {1}", comparacion1, comparacion2);
                }
            }
            Console.ReadLine();
        }
    }
}
