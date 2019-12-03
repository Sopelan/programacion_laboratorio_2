using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();
            alumno.nombre = "marcos";
            alumno.apellido = "sopelana";
            alumno.legajo = 12341412;
            alumno2.nombre = "ranma";
            alumno2.apellido = "saotome";
            alumno2.legajo = 2133232;
            alumno3.nombre = "akane";
            alumno3.apellido = "saotome";
            alumno3.legajo = 2312231;

            alumno.Estudiar(7, 9);
            alumno.CalcularFinal();
            Console.WriteLine(alumno.Mostrar());
            alumno2.Estudiar(2, 5);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());
            alumno3.Estudiar(10, 4);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());
            Console.Read();
        }
    }
}
