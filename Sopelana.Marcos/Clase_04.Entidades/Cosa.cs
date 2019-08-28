using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clase_04.Entidades
{
    public class Cosa
    {
        
        private int entero;
        private string cadena;
        private DateTime fecha;
        public string Mostrar()
        {
            return Convert.ToString(entero) + " " + cadena + " " + Convert.ToString(fecha);
        }
        public void EstablecerValor(int num)
        {
            entero = num;
        }
        public void EstablecerValor(string caden)
        {
            cadena = caden;
        }
        public void EstablecerValor(DateTime fech)
        {
            fecha = fech;
        }
        public Cosa()
        {
            entero = -1;
            cadena = "Sin valor";
            fecha = DateTime.Now;
        }
        public Cosa(string caden):this()
        {
            cadena = caden;
        }
        public Cosa(string caden, DateTime date): this(caden)
        {
            fecha = date;
        }
        public Cosa(string caden, DateTime date, int ent): this(caden,date)
        {
            entero = ent;
        }

    }
    
}
