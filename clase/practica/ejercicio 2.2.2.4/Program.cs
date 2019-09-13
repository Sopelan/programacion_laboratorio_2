using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como contraseña "1111". 
namespace ejercicio_2._2._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ind;
            int con;
            do
            {
                Console.WriteLine("ingrese su identificador");
                ind = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese su contraseña");
                con = Convert.ToInt32(Console.ReadLine());
            } while (ind != 1234 || con != 1111);
            Console.WriteLine("contraseña correcta e identificador correctos");
            Console.Read();
        }
    }
}
