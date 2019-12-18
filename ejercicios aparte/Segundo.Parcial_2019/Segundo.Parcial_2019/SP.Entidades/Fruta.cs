using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fruta-> _color:string y _peso:double (protegidos); TieneCarozo:bool (prop. s/l, abstracta);
//constructor con 2 parametros y FrutaToString():string (protegido y virtual, retorna los valores de la fruta)
namespace ENTIDADES.SP
{
    public abstract class Fruta
    {
        public string _color;
        public double _peso;

        public abstract bool TieneCarozo
        {
            get;
        }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        public Fruta()
        {
        }

        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this._color + " " + this._peso);
            return sb.ToString();
        }

    }
}
