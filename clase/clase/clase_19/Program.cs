using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Crear un proyecto del tipo Class Library.
Crear la interfaz IArchivo con los métodos:
    guardar(string archivo, T datos) : bool 
    leer(string archivo, T datos) : bool 
Crear las clases Texto y Xml que implementarán la interfaz antes creada. 
Texto: 
    El método guardar recibirá el nombre del archivo y un texto. Retornará True si todo salió bien. 
    El método leer recibirá el nombre del archivo y una variable out del tipo string donde deberá retornar el contenido de dicho archivo. Retornará True si todo salió bien. 
Xml: 
    El método guardar recibirá el nombre del archivo y un objeto genérico a serializar. Retornará True si todo salió bien. 
    El método leer recibirá el nombre del archivo y una variable del tipo out del tipo requerido donde deberá retornar el contenido de dicho archivo. Retornará True si todo salió bien.
Para probar el código, generar un proyecto del Console.
    Copiar las clases Persona y Empleado del ejercicio 11. Se deben poder serializar y recuperar todos los atributos. Realizar las modificaciones necesarias para poder realizar las acciones pedidas. 
    Instanciar en el Main un objeto de la clase Empleado y guardarlo en ambos formatos. 
    Crear otro objeto de la clase Empleado y leer el contenido del mismo archivo, luego mostrarlo por pantalla. 
    Leer el archivo de texto y mostrar su contenido por pantalla.
 * */
namespace clase_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("ranma", "saotome", "12334", Empleado.EPuestoJerarquico.Administracion , 20000);
            empleado.GuardarEnPersona(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\clase\clase\clase_19\persona.xml");
            empleado.GuardarEnTexto(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\clase\clase\clase_19\texto.txt");
            Console.Read();
            Empleado.LeerEnPersona(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\clase\clase\clase_19\persona.xml", out Empleado empleado2);
            Empleado.LeerEnTexto(@"C:\Users\sopelan1\Desktop\programacion_laboratorio_2\clase\clase\clase_19\texto.txt", out string mensaje);
            Console.WriteLine(empleado2.ToString());
            Console.WriteLine(mensaje);
            Console.Read();
        }
    }
}
