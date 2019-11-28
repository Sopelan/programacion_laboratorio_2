using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Tomar como base el ejercicio de la clase 20.  
Modificar la interfaz ISerializable y agregar los métodos:
    guardar() : bool 
    leer(out T) : bool 
    modificar() : bool 
    eliminar() : bool
Implementar los métodos en ambas clases para que guarden, lean, modifiquen y eliminen sus datos de la base de datos aquí dada
*/
namespace Clase_8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEmpleado());
        }
    }
}
