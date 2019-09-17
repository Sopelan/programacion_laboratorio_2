using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;
namespace Clase_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo c1 = "Primer capitulo";
            Capitulo c2 = "Segundo capitulo";
            Capitulo c3 = "Tercer capitulo";
            Console.WriteLine(c1.Numero);
            Console.WriteLine(c1.Titulo);
            Console.WriteLine(c1.Paginas);
            
            Console.Read();
        }
    }
}
