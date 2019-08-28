using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;
namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa c = new Cosa();
            Console.WriteLine(c.Mostrar());
            c.EstablecerValor(DateTime.Now);
            c.EstablecerValor("hola");
            c.EstablecerValor(2);
            Console.WriteLine(c.Mostrar());
            Console.Read();
            
        }
    }
}
