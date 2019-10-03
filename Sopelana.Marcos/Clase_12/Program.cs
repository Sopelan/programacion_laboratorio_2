
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12y14.Entidades;
namespace Clase_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita();
            Local local1 = new Local("tucasa", 30, "mi casa", 2.65f);
            Provincial provincial1 = new Provincial("mi casa", Franja.Franja_1, 21, "tu casa");
            Local local2 = new Local("tu casa", 45, "mi casa", 1.99f);
            Provincial provincial2 = new Provincial(Franja.Franja_3, provincial1);
            Telefonica += local1;
            Telefonica += provincial1;
            Telefonica += local1;
            Telefonica += local2;
            Telefonica += provincial2;
            Telefonica += provincial2;
            Console.WriteLine(Telefonica.ToString());
            Console.WriteLine();
            Telefonica.OrdenarLlamadas();
            Console.WriteLine(Telefonica.ToString());
            Console.Read();
        }
    }
}
