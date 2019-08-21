using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mi_clase;
using Clase02.Entidades;
namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre2;
            bool boo;
            string msj;
            
            MiClase.nombre = "juan";
            MiClase.edad = 23;
            MiClase.MostrarEdad();
            nombre2 = MiClase.RetornarNombre();
            boo = MiClase.CompararNombre("juan");
            Console.WriteLine(nombre2);
            Console.WriteLine(boo);
            Mi_libreria.Class1.nombre = "roman";
            Console.WriteLine(Mi_libreria.Class1.RetornoNombre());
            
            Sello.mensaje = "hola mundo";
            msj = Sello.Imprimir();
            Sello.Borrar();
            msj = Sello.Imprimir();
            Sello.mensaje = "hola";
            Sello.Color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.Read();
        }
    }
}
