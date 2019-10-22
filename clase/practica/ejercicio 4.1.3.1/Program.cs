using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Un programa que almacene en una tabla el número de días que tiene cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año 
 *  (por ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 365). */
namespace ejercicio_4._1._3._1
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
            Console.WriteLine("elige el dia del mes y te diremos cuanto dias llevan");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
                suma += num[i];
            suma += numero;
            Console.WriteLine("el dia {0} del mes {1} es del año {2}", numero, mes[n - 1], suma);
            Console.Read();

        }
    }
}
