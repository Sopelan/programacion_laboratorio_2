using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Crear un proyecto de WindowsForm, otro de Console y una Class Library.   
    Class Library:
        Utilizar la clase Empleado de la Clase 8 
        Modificar el método Mostrar para que reciba un elemento del tipo IGrafica. El método retornará void y utilizará a IGrafica para mostrar su contenido. 
    Crear la interfaz IGrafica que contenga el método MostrarEnGUI(string). Console y WindowsForm: 
        Implementarán a IGrafica. 
        Crear un objeto de la clase Empleado y utilizar el método Mostrar para mostrar los datos por pantalla
 NOTA: en la aplicación de consola necesitarán agregar una clase propia (Vista) con un método propio (Main) que implementará la interfaz. El Main de Program sólo instanciará una vista y llamará al método Main de Vista
 * */
namespace clase_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Vista vista = new Vista();
            Empleado empleado = new Empleado("ranma", "saotome", "123", Empleado.EPuestoJerarquico.Accionista, 20000);
            empleado.Mostrar(vista);
            Console.ReadLine();
        }

    }
}
