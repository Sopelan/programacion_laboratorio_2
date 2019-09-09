using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100. 
 Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la siguiente firma: 
 bool Validar(int valor, int min, int max): 
 a. valor: dato a validar 
 b. min y max: rango en el cual deberá estar la variable valor.  
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. 
Nota: Utilizar variables escalares, NO utilizar vectores.  */
namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool condiccion;
            int min = int.MaxValue;
            int max = int.MinValue;
            int suma = 0;
            float promedio;
            int i;
            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero entre -100 y 100");
                num = Convert.ToInt32(Console.ReadLine());
                condiccion = Validacion.Validar(num, -100, 100);
                while(condiccion == false)
                {
                    Console.WriteLine("Error!!!!\nreingrese un numero entre -100 y 100");
                    num = Convert.ToInt32(Console.ReadLine());
                    condiccion = Validacion.Validar(num, -100, 100);
                }
                if(min > num)
                    min = num;
                if (max < num)
                    max = num;
                suma += num;
            }
            promedio = suma / 10f;
            Console.WriteLine("el minimo es: " + min);
            Console.WriteLine("el maximo es: " + max);
            Console.WriteLine("el promedio de {1} entre 10 es: {0}" ,promedio, suma);
            Console.Read();
        }
        
    }
}
