using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario
un primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto
de 0 por cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al 
usuario un segundo número y se mostrará el producto de ambos. */
namespace ejercicio_2._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int producto;
            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0) Console.WriteLine("El producto de 0 por cualquier numero es 0");
            else
            {
                Console.WriteLine("Ingrese un segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());
                producto = num1 * num2;
                Console.WriteLine("El producto de {0} y {1} es {2}", num1 , num2, producto);
            }
            Console.Read();
        }
    }
}
