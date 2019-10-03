using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear la clase Cajón, la cual contendrá
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
        QuitarFruta: quitará una fruta al azar. Utilizar Random.*/
namespace clase_07
{
    class Cajon
    {
        public List<Fruta> _frutas;
        public decimal _volumen;
        private Cajon()
        {
            this._frutas = new List<Fruta>();
        }
        public Cajon(int volumen) : this()
        {
            this._volumen = volumen;
        }
        public decimal CalcularEspacioDisponible()
        {
            return this._volumen - _frutas.Count;
        }
        public string MostraContenido()
        {
            StringBuilder sb = new StringBuilder(); 

            sb.AppendLine("frutas: ");
            sb.AppendLine("el volumen total es " + this._volumen);
            sb.AppendLine();
            for(int  i = 0; i< _frutas.Count;i++)
            {
                sb.AppendLine("fruta: " + (i+1));
                sb.AppendLine("su peso es: " + _frutas[i]._peso);
                sb.AppendLine("su volumen es: " + _frutas[i]._volumen);
                sb.AppendLine();
            }

            return sb.ToString();
        }
        public void AgregarFruta(Fruta f)
        {
            if (CalcularEspacioDisponible() > 0)
                this._frutas.Add(f);
            else
                Console.WriteLine("no hay espacio");
        }
        public void QuitarFruta()
        {
            Random quitar = new Random();
            int remove = quitar.Next(0, this._frutas.Count - 1);
            this._frutas.RemoveAt(remove);
        }


    }
}
