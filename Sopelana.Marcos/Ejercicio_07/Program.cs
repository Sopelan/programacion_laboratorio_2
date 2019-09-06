using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date;
            DateTime now = DateTime.Now;
            TimeSpan resta;
            Console.WriteLine("ingrese su fecha de nacimiento");
            date = Convert.ToDateTime(Console.ReadLine());
            resta = now - date;
            Console.WriteLine(resta.Days+ " dias de diferencia entra tu fecha de nacimiento y ahora");
            Console.Read();
        }
    }
}
