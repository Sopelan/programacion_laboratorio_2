using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ENTIDADES.SP
{
    public class Manejadora : EventArgs
    {
        public static void Imprimir(double precio, EventArgs e)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "cajones.txt");
                streamWriter.WriteLine(string.Format("{0}/{1}/{2} del {4}:{5}:{3}",DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year,DateTime.Now.Second,DateTime.Now.Hour,DateTime.Now.Minute));
                streamWriter.WriteLine("Precio Total: " + precio);
                streamWriter.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
