using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace sql_2
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=SOPELAN;Initial Catalog=productos;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public string insertar(int id, string nombre, string apellido)
        {
            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("Insert into Table_1(id,nombre,apellido) values(" + id + ",'" + nombre + "','" + apellido + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                salida = "No se inserto";
                MessageBox.Show(e.Message);
            }
            return salida;
        }
        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Table_1 where id=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return contador;
        }
        public void cargarPersonas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Table_1",cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void LlenarTextBoxConsulta(int id, TextBox txtNombre,TextBox txtApellido)
        {
            try
            {
                cmd = new SqlCommand("Select * from Table_1 where id=" + id +"",cn);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    txtNombre.Text = dr["nombre"].ToString();
                    txtApellido.Text = dr["apellido"].ToString();
                }
                dr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public string actualizar(int id, string nombre,string apellido)
        {
            string salida = "se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Table_1 set nombre ='"+nombre+"' ,apellido ='"+apellido+"'  where id= "+id+"",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                salida = "no se actualizo";
            }
            return salida;
        }
    }
}
