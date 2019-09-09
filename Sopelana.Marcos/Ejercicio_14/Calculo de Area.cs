using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Calculo_de_Area
    {
       double CalcularCuadrado(double lado)
       {
            return Math.Pow(lado, 2);
       }
       double CalcularTriangulo(double Base , double altura)
       {
            return Base * altura / 2;
       }
       double CalcularCirculo(double radio)
       {
            return Math.Pow(radio / 2, 2) * Math.PI;
       }

    }
}
