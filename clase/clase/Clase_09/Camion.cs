using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09
{
    public class Camion: Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;
        public Camion(string patentes, byte cantRuedas, EMarcas marca, int cantidadAsientos, float tara, float cilindrada) : base(patentes, cantRuedas, marca)
        {
            this._cantidadAsientos = cantidadAsientos;
            this._tara = tara;
            this._cilindrada = cilindrada;
        }
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Clase Camion");
            sb.Append(base.Mostrar());
            sb.AppendLine("Cantidad de Asientos: " + this._cantidadAsientos);
            sb.AppendLine("Tara: " + this._tara);
            sb.AppendLine("Cilindrada: " + this._cilindrada);

            return sb.ToString();
        }
    }
}
