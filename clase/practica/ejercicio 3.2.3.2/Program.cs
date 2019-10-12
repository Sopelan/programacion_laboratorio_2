using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Crear un programa que use tres variables x,y,z. Las tres serán números
reales, y nos bastará con dos cifras decimales. Deberá pedir al usuario los valores para
las tres variables y mostrar en pantalla el valor de x2 + y - z (con exactamente dos
cifras decimales).*/
namespace ejercicio_3._2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            float z;
            float resultado;
            Console.WriteLine("ingrese el num x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el num y");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el num z");
            z = float.Parse(Console.ReadLine());
            resultado = (x * x) + y - z;
            Console.WriteLine("El resultado es{0} ", resultado);
            Console.Read();
        }
    }
}
