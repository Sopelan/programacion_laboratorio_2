using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_08;
/* Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N empleados de una fábrica. 
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados 
por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos. Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto, 
el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. Nota: Utilizar estructuras repetitivas y selectivas.  */
namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 2;
            Sumar[] empleado = new Sumar[cantidad];
            Boolean opcion = true;
            int i = 0;
   
            while (opcion)
            {
                if (cantidad <= i)
                {
                    cantidad++;
                    empleado = new Sumar[cantidad];
                }
                Console.WriteLine("ingrese el valor hora");
                empleado[i].valorHora = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el nombre");
                empleado[i].nombre = Console.ReadLine();
                Console.WriteLine("hace cuanto trabajas");
                empleado[i].antiguedad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cuantos horas trabajas en el mes");
                empleado[i].horasTrabajadas = Convert.ToInt32(Console.ReadLine());
                i++;
                Console.WriteLine("ingresara otro?\nt:true\nf:false");
                opcion = Convert.ToBoolean(Console.Read());

            }
            for (i = 0; i < empleado.Length; i++)
            {
                Console.WriteLine(empleado[i].Mostrar());
            }




            Console.Read();




        }
    }
}
