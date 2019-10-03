using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Se pide realizar una aplicación de consola con la siguiente funcionalidad:  
Crear una clase llamada Fruta con los atributos públicos y de instancia:
    _peso: será un valor del tipo float
    _volumen: será un valor del tipo entero que indicará el espacio ocupado por la fruta 
    Crear un constructor por defecto que de valores aleatorios a ambos atributos. Peso será un valor entre 1 y 5, volumen entre 1 y 10.
Crear la clase Cajón, la cual contendrá
    Atributos de instancia y privados: 
        _frutas: lista de objetos del tipo Frutas 
        _volumen: será un valor del tipo entero que indicará el espacio total del cajón 
    Constructores 
        Por defecto, privado y de instancia. Sólo aquí se instanciará la lista de frutas. 
        Cajon(int) público y de instancia, recibirá el volumen del cajón como parámetro. 
    Métodos públicos y de instancia: 
        CalcularEspacioDisponible: calculará cuánto espacio queda en el cajón 
        MostrarContenido: retornará un string con el volumen total ocupado del cajón, el volumen total y los datos de las frutas 
        AgregarFruta(Fruta) agregará una nueva fruta a la lista, si hay espacio. 
        QuitarFruta: quitará una fruta al azar. Utilizar Random.
Se le mostrará al usuario una lista de frutas, preguntándole si desea agregar o quitar alguna fruta, repitiendo esto último tantas veces como el usuario lo desee. */
namespace clase_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajon cajon = new Cajon(3);
            Fruta fruta = new Fruta();
            Fruta fruta2 = new Fruta();
            Fruta fruta3 = new Fruta();
            Fruta fruta4 = new Fruta();
            cajon.AgregarFruta(fruta);
            cajon.AgregarFruta(fruta2);
            cajon.AgregarFruta(fruta3);
            cajon.AgregarFruta(fruta4);
            Console.WriteLine(cajon.MostraContenido());
            cajon.QuitarFruta();
            cajon.AgregarFruta(fruta4);
            Console.WriteLine(cajon.MostraContenido());
            Console.Read();
        }
    }
}
