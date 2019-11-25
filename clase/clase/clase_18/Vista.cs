using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_18
{
    public class Vista : IGrafica
    {
        public void MostrarEnGUI(string frase)
        {
            Console.WriteLine(frase);
        }
    }
}
