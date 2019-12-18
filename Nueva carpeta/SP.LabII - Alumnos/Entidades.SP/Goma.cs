using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Goma-> soloLapiz:bool(publico); PreciosCuidados->true; 
//Reutilizar UtilesToString en ToString() (mostrar todos los valores).
namespace Entidades.SP
{
    public class Goma : Utiles
    {
        public bool soloLapiz;

        public override bool PreciosCuidados
        {
            get
            {
                return true;
            }
        }

        public Goma(bool soloLapiz, string marca, double precio) : base(marca, precio)
        {
            this.soloLapiz = soloLapiz;
        }

        protected override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sacapunta");
            sb.AppendLine(base.UtilesToString());
            sb.Append("Solo Lapiz: " + this.soloLapiz);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}


