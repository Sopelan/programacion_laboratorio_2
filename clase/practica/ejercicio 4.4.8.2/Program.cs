using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Un programa que pida tu nombre, tu día de nacimiento y tu mes de nacimiento y lo junte todo en una cadena, separando el nombre de la fecha por una coma y el día del mes por una barra inclinada, así: "Juan, nacido el 31/12"
namespace ejercicio_4._4._8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string nombre;
            int dia;
            int mes;
            Console.WriteLine("Ingrese tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese tu dia de nacimiento");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese tu mes de nacimiento");
            mes = Convert.ToInt32(Console.ReadLine());
            sb.AppendLine(nombre + ", nacido el " + dia.ToString("00") + "/" + mes.ToString("00"));
            Console.WriteLine(sb);
            Console.ReadLine();
        
        }
    }
}
