using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18.Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get { return this._color; } }
        public string Marca { get {return this._marca; } }

        public Auto(string color ,string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        
        public static bool operator !=(Auto a , Auto b)
        {
            return !(a == b);
        }
        public static bool operator ==(Auto a , Auto b)
        {
            return a.Marca == b.Marca && a.Color == b.Color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Marca: " + this.Marca + " - Color: " + this.Color);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Auto)
                if((Auto) obj == this)
                return true;
            return false;

        }

    }
}
