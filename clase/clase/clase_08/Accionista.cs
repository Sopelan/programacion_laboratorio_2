using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_08
{
    public class Accionista : Persona
    {
        private int _porcionAccionaria;
        public int PorcionAccionaria
        {
            get
            {
                if (this._porcionAccionaria >= 0 && this._porcionAccionaria <= 100)
                    return this._porcionAccionaria;
                return 1;
            }
        }
        public Accionista(string nombre , string apellido , int porcionAccionaria):base(nombre,apellido)
        {
            this._porcionAccionaria = porcionAccionaria;
        }
        public override string PosicionSocietaria()
        {
            return "Accionista con el " + this.PorcionAccionaria + "% de la porcion accionaria."; 
        }
        public static bool operator ==(Accionista a1 , Accionista a2)
        {
            return (a1.Nombre == a2.Nombre) && (a1.Apellido == a2.Apellido) && (a1.PorcionAccionaria == a2.PorcionAccionaria);
        }
        public static bool operator != (Accionista a1 , Accionista a2)
        {
            return !(a1 == a2);
        }
    }
}
