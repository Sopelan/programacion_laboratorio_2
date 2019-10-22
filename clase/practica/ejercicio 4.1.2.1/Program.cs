using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Un programa que almacene en una tabla el número de días que tiene cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes. 
namespace ejercicio_4._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 31,28,31,30,31,30,31,31,30,31,30,31};
            string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int i;
            Console.WriteLine("elige un mes y te diremos cuantos dias tiene\n1.Enero\n2.Febrero\n3.Marzo\n4.Abril\n5.Mayo\n6.Junio\n7.Julio\n8.Agosto\n9.Septiembre\n10.Octubre\n11.Noviembre\n12.Diciembre");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El mes de {0} tiene {1} dias", mes[i - 1], num[i - 1]);
            Console.Read();


        }
    }
}
