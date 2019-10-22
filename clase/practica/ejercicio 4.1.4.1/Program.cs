using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* A partir del ejercicio 4.1.3.1, crear otro que pida al usuario que le indique la fecha, detallando el día (1 al 31) y el mes (1=enero, 12=diciembre), como respuesta muestre en pantalla el número de días que quedan hasta final de año*/
namespace ejercicio_4._1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int n;
            int suma = new int();
            int numero;
            Console.WriteLine("elige un mes \n1.Enero\n2.Febrero\n3.Marzo\n4.Abril\n5.Mayo\n6.Junio\n7.Julio\n8.Agosto\n9.Septiembre\n10.Octubre\n11.Noviembre\n12.Diciembre");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("elige el dia del mes y te diremos cuantos dias faltan para que termine el año");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
                suma += num[i];
            suma += numero;
            Console.WriteLine("quedan {0} dias para que termine el año", 366 - suma );
            Console.Read();
        }
    }
}
