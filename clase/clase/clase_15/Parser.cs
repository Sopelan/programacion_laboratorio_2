using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Generar una clase estática llamada Parser.
1. Agregar un método TryParse(string, out int) : bool cuyo funcionamiento sea exactamente igual al de Int32.TryParse. 
2. Agregar un método Parse(string) : int cuyo funcionamiento sea exactamente igual al de Int32.Parse. 
    1. Capturar por separado las excepciones: 
        1. FormatException: agregará al mensaje “... por error de formato”. 
        2. OverflowException: agregará al mensaje “... por tamaño del dato” 
3. En caso de falla, deberá devolver la excepción ErrorParserException generada por el alumno, con el mensaje “El string no podrá ser convertido”. Utilizar la propiedad InnerException de la clase padre. 
4. Dentro de ambos métodos, para convertir de String a Entero utilizar Int32.Parse. Controlar las excepciones dentro de los métodos y luego lanzarlas.
  NOTAS:  El método Parse deberá capturar y lanzar (throw) la excepción capturada. */
namespace clase_15
{
    public static class Parser
    {
        public static bool TryParse(this string numero, out int salida)
        {
            return Int32.TryParse(numero, out salida);
        }
        public static int Parse(this string numero)
        {
            int num;
            try
            {
                num = Int32.Parse(numero);
                return num;
            }
            catch (FormatException e)
            {
                e = new FormatException("por error de formato", e);
                return 0;
            }
            catch (OverflowException e)
            {
                e = new OverflowException("por tamaño", e);
                return 0;
            } 

        }
        

    }
}
