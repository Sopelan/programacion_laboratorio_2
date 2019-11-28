using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Banana:Fruta
    {
        protected string _paisOrigen;

        protected override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }
        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }

        public Banana(string color, double peso , string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre de la fruta: " + this.Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Pais de origen: " + this._paisOrigen);
            sb.Append("Tiene carozo? " + this.TieneCarozo);
            return sb.ToString();
        }
    }
}
