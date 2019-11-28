using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ENTIDADES.SP
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        protected abstract bool TieneCarozo { get; }

        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        public Fruta()
        {
            this._color = "";
            this._peso = 0;
        }

        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Color de la fruta: " + this._color);
            sb.Append("El peso de la fruta: " + this._peso);
            return sb.ToString();
        }
    }
}
