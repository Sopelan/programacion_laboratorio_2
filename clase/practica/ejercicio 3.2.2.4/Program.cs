using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Si se ingresan E euros en el banco a un cierto interés I durante N años, el dinero obtenido viene dado por la fórmula del interés
compuesto: Resultado = e (1+ i)n Aplicarlo para calcular en cuanto se convierten 1.000 euros al cabo de 10 años al 3% de interés anual.*/
namespace ejercicio_3._2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float E;
            float I;
            float N;
            float resultado;
            Console.WriteLine("ingrese euros");
            E = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el interes");
            I = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los años");
            N = float.Parse(Console.ReadLine());
            resultado = E * (I / 100 * N) + E;
            Console.WriteLine("Si se ingresan {0} euros en el banco a un cierto interés {1}% durante {2} años, se obtiene{3}", E, I, N, resultado);
            Console.Read();
        }
    }
}
