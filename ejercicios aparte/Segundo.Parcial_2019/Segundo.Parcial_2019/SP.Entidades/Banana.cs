using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
//Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
namespace ENTIDADES.SP
{
    public class Banana : Fruta
    {
        public string _paisOrigen;

        public string  Nombre
        {
            get
            {
                return "Banana";
            }
        }
        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public Banana(string color, double peso , string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        public Banana()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("tiene carozo?: " + this.TieneCarozo);
            sb.Append(this._paisOrigen);
            return sb.ToString();
        }


    }
}
