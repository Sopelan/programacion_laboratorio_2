using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data.Sql;
using System.Data.SqlClient;
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
        public static bool EsNulo(this Object obj)
        {
            return obj.Equals(null);
        }
        public static List<Persona> ObtenerListadoBD()
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.conexion);
                SqlCommand sqlCommand = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]"
                };
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<Persona> personas = new List<Persona>();
                while(sqlDataReader.Read() != false)
                {
                    Persona p = new Persona(sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), Convert.ToInt32(sqlDataReader[3]));
                    personas.Add(p);
                }
                sqlConnection.Close();
                sqlDataReader.Close();
                return personas;
            }
            catch(Exception message)
            {
                Console.WriteLine(message.Message);
                return null;
            }
        }
    }
}
