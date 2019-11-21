using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("ingresar el numero");
            numero = Console.ReadLine();
            int num = numero.Parse();
            numero.TryParse(out int salida);
            Console.WriteLine(num + salida);
            Console.Read();
        }
    }
}
