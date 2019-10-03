using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clase_12y14.Entidades
{
    public class Local : Llamada
    {
        protected float _costo;
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
           return (float) this._costo * base.Duracion;
        }
        public Local(Llamada unaLlamada , float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo){}
        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            return false;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("costo: " + this.CostoLlamada);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }

    
}
