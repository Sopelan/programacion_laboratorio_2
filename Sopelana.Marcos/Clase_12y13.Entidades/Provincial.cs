using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12y14.Entidades
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;
                default:
                    break;
            }
            return retorno;
        }
        public Provincial(Franja miFranja, Llamada unaLlamada) : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino){}
        public Provincial(string origen , Franja miFranja , float duracion ,string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("costo: " + this.CostoLlamada);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
    
}
