using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Crea una función que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), usando la expresión d = raíz [ (x1-x2)2 + (y1-y2)2 ]. 
namespace ejercicio_5._9._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 5;
            double y1 = 3;
            double x2 = 2;
            double y2 = 4;
            double distancia = DistanciaDosPuntos(x1, y1, x2, y2);
            Console.WriteLine("La distancia entre dos puntos ({0},{1}) y ({2},{3}) es: {4}",x1,y1,x2,y2,distancia);
            Console.ReadLine();
        }
        static double DistanciaDosPuntos(double x1, double y1, double x2, double y2)
        {
            double retorno = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
            return retorno;
        }
    }
}
