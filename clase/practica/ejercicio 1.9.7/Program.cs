using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Pide al usuario una cantidad de "millas" y muestra la equivalencia en metros, usando: 1 milla = 1609.344 metros. */
namespace ejercicio_1._9._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int milla;
            float metros;
            Console.WriteLine("ingrese una cantidad de milla");
            milla = Convert.ToInt32(Console.ReadLine());
            metros = milla * 1609.344f;
            Console.WriteLine("{0} milla equivale a {1} metros", milla, metros);
            Console.Read();
        }
    }
}
