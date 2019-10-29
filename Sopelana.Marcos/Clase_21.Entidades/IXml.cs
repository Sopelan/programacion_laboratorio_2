using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21.Entidades
{
    public interface IXml
    {
        bool Guardar(string texto);
        bool Leer(string texto, out object obj);
    }
}
