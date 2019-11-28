using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre
        {
            get
            {
                return "Duranzo";
            }
        }
        protected override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Durazno(string color, double peso , int cantPelusa ) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre de la fruta: " + this.Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("cantidad de Pelusa: " + this._cantPelusa);
            sb.Append("Tiene carozo? " + this.TieneCarozo);
            return sb.ToString();
        }
    }
}
