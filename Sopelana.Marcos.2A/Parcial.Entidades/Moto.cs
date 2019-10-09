using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Moto : Vehiculo
    {
        public ECilindrada cilindrada;

        public Moto(string marca, EPais pais , string modelo , float precio , ECilindrada cilindrada):base(marca,pais, modelo , precio)
        {
            this.cilindrada = cilindrada;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;
            return false;
        }
        public static implicit operator Single(Moto m)
        {
            return m.precio;
        }
        public static bool operator != (Moto a, Moto b)
        {
            return !(a == b);
        }
        public static bool operator == (Moto a , Moto b)
        {
            return (a.cilindrada == b.cilindrada) && ((Vehiculo)a == (Vehiculo)b);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine("cilindrada: " + this.cilindrada);
            return sb.ToString();
        }
    }
}
