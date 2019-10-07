using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Vehiculo
    {
        public enum EMarcas { Honda,Ford,Zanella,Scania,Iveco,Fiat}
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        public string Patentes { get { return _patente; } }
        public Vehiculo(string patentes,byte cantRuedas,EMarcas marca)
        {
            this._patente = patentes;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this.Patentes);
            sb.AppendLine("Cantidad de ruedad: " + this._cantRuedas);
            sb.AppendLine("La marca es: " + this._marca);
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1._marca == v2._marca) && (v1._patente == v2._patente);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        
    }
}
