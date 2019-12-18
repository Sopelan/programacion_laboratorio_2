using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sacapunta-> deMetal:bool(publico); 
//Reutilizar UtilesToString en ToString() (mostrar todos los valores).
namespace Entidades.SP
{
    public class Sacapunta : Utiles
    {
        public bool deMetal;

        public override bool PreciosCuidados
        {
            get
            {
                return false;
            }
        }

        public Sacapunta(bool deMetal, double precio, string marca) : base(marca, precio)
        {
            this.deMetal = deMetal;
        }

        protected override string UtilesToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sacapunta");
            sb.AppendLine(base.UtilesToString());
            sb.Append("Es de Metal: " + this.deMetal);
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }



    }
}
