using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
namespace Clase_27.Entidades
{
    public class Class1 : PersonaExterna
    {
        public Class1(string nombre, string apellido, int edad, ESexo sexo) : base(nombre, apellido, edad, sexo)
        {

        }
    }
}
