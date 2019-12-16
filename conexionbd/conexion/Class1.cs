using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace conexion
{
    public class ConexionBD
    {
        string cadena = "Data Source=SOPELAN;Initial Catalog=productos; Integrated Security=True";
        public SqlConnection connection = new SqlConnection();

        public ConexionBD()
        {
            connection.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error al abrir la BD " + e.Message);
            }
        }
        public void Cerrar()
        {
            connection.Close();
        }
    }
    
}
