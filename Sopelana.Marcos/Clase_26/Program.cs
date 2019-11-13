using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_26.Entidades;
namespace Clase_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", "Perez", 123);
            empleado.LimiteSueldo += new LimiteSueldoDelegado(empleado.ManejadorLimiteSueldo);
            empleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(Empleado.ManejadorLimiteSueldoMejorado);
            empleado.Sueldo = 33000;
            Console.WriteLine(empleado.ToString());
            Console.Read();
        }
    }
}
