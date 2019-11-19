using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_27.Entidades;
using Entidades.Externa.Sellada;
namespace Clase_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("daniel", "fernando",22323213);
            PersonaExternaSellada persona2 = new PersonaExternaSellada("daniel", "fernando",23,ESexo.Masculino);
            Console.WriteLine(persona2.ObtenerInfo());
            
            Console.ReadLine();
        }
    }
}
