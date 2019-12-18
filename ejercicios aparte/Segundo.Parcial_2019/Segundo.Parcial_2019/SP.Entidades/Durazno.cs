using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
namespace ENTIDADES.SP
{
    public class Durazno : Fruta
    {
        public int _cantPelusa;

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }
        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public Durazno(string color, double peso , int cantPelusa) : base(color, peso)
        {
            this._cantPelusa = cantPelusa;
        }

        public Durazno()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("tiene carozo?: " + this.TieneCarozo);
            sb.Append(this._cantPelusa);
            return sb.ToString();
        }
    }
}
