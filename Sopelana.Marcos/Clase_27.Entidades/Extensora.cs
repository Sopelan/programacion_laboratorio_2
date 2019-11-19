using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
namespace Clase_27.Entidades
{
    public static class Extensora
    {
        public static string ObtenerInfo(this PersonaExternaSellada persona)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + persona.Nombre);
            sb.AppendLine("Apellido: " + persona.Apellido);
            sb.AppendLine("Edad: " + persona.Edad);
            sb.AppendLine("Sexo: " + persona.Sexo);
            return sb.ToString();
        }

    }
}
