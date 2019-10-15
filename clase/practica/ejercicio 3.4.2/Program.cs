using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.  
namespace ejercicio_3._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string contraseña;
            string repite;
            Console.WriteLine("ingrese el nombre de usuario");
            usuario = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("ingrese la contraseña");
                contraseña = Console.ReadLine();
                Console.WriteLine("reingrese la contraseña");
                repite = Console.ReadLine();
                if (contraseña == repite)
                {
                    Console.WriteLine("ya se creo el usuario: {0} con la contraseña: {1} y se repite: {2}",usuario,contraseña,repite);
                    break;
                }
                else
                    Console.WriteLine("no son iguales las contraseñas");
            }
            Console.ReadLine();
        }
    }
}
