using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Preguntar al usuario su edad, que se guardará en un "byte". A continuación, se deberá le deberá decir que no aparenta tantos años (por ejemplo, "No aparentas 20 años").
namespace ejercicio_3._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte edad;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("No aparentas {0} años", edad);
            Console.Read();
        }
    }
}
