using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12y14.Entidades
{
    public class Centralita
    {
        private List<Llamada> _listadeLlamadas;
        protected string _razonSocial;
        public float GananciaPorLocal { get { return this.CalcularGanancias(tipoLlamada.Local); } }
        public float GananciaPorProvincial { get { return this.CalcularGanancias(tipoLlamada.Provincial); } }
        public float GananciaTotal { get { return this.CalcularGanancias(tipoLlamada.Todas); }}
        public List<Llamada> Llamadas { get { return _listadeLlamadas; } }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listadeLlamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancias(tipoLlamada tipo)
        {
            float retornoProvincial = 0;
            float retornoLocal = 0;
            foreach (Llamada l in this._listadeLlamadas)
            {
                if (l is Local)
                    retornoLocal += l.CostoLlamada;
                else if (l is Provincial)
                    retornoProvincial += l.CostoLlamada;

            }
            if (tipo == tipoLlamada.Local)
                return retornoLocal;
            else if (tipo == tipoLlamada.Provincial)
                return retornoProvincial;
            else
                return retornoLocal + retornoProvincial;
            
        }
        public Centralita()
        {
            _listadeLlamadas = new List<Llamada>();
            _razonSocial = "";
        }
        public Centralita(string nombreEmpresa) : this()
        {
            _razonSocial = nombreEmpresa;
        }
        public static bool operator != (Centralita central , Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }
        public static Centralita operator +(Centralita central , Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
                central.AgregarLlamada(nuevaLlamada);
            else
                Console.WriteLine("ya existe");
            return central;
        }

        public static bool operator == (Centralita central , Llamada nuevaLlamada)
        {
            for (int i = 0; i < central.Llamadas.Count; i++)
            {
                if (central.Llamadas[i] == nuevaLlamada)
                    return true;
            }
            return false;
        }
        public void OrdenarLlamadas()
        {
            _listadeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Llamadas.Count; i++)
                sb.AppendLine(Llamadas[i].ToString());
            return sb.ToString();

        } 


    }
}
