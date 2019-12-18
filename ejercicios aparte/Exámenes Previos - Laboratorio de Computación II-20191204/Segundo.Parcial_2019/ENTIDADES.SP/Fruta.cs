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
        protected string _color;
        protected double peso;

        public abstract bool TieneCarozo { get; }
        public string Color { get => _color; set => _color = value; }
        public double Peso { get => peso; set => peso = value; }

        public Fruta(string color, double peso)
        {
            this.Color = color;
            this.Peso = peso;
        }
        public Fruta()
        {

        }

        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Color: " + this.Color);
            sb.Append("Peso: " + this.Peso);
            return sb.ToString();
        }

    }
}
