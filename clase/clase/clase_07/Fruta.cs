using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear una clase llamada Fruta con los atributos públicos y de instancia:
    _peso: será un valor del tipo float
    _volumen: será un valor del tipo entero que indicará el espacio ocupado por la fruta 
    Crear un constructor por defecto que de valores aleatorios a ambos atributos. Peso será un valor entre 1 y 5, volumen entre 1 y 10.*/
namespace clase_07
{
    class Fruta
    {
        public float _peso;
        public decimal _volumen;

        public Fruta()
        {
            this._peso = this.RandomNumber(1, 5);
            this._volumen = this.RandomNumber(1, 10);  
        }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random(2);
            int retorno = random.Next(min, max);
            return retorno;
        }

    }
}
