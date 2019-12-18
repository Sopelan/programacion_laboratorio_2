using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Entidades.SP
{
    public class Ticketadora
    {
        public static bool ImprimirTicket(double precioTotal)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log", true);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Precio Total :$" + precioTotal);

                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            } 
        }
    }
}
