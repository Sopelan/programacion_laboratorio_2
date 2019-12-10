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
        protected string _paisOrigen; 

        public string Nombre
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

        public Banana(string color, double peso, string paisOrigen) : base(color, peso)
        {
            this._paisOrigen = paisOrigen;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("Pais de Origen: " + this._paisOrigen);
            sb.Append("Tiene carozo? " + this.TieneCarozo);
            return sb.ToString();
        }

    }
}
