using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        SqlConnection conexion;
        DataTable tablaPersonas;
        SqlDataAdapter dataAdapter;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();

            this.tablaPersonas = new DataTable("[personas_bd].[dbo].[personas]");

            this.CargarDataTable();

        }

        private void CargarDataTable()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                //conexion.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conexion;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TOP 1000 [id] " +
                    ",[nombre] " +
                    ",[apellido]" +
                    ",[edad]" +
                    " FROM[personas_bd].[dbo].[personas]";

                /*SqlDataReader dataReader;
                dataReader = sqlCommand.ExecuteReader();
                this.tablaPersonas.Load(dataReader);
                conexion.Close();
                sqlCommand.Clone();
                dataReader.Close();*/

                this.dataAdapter = new SqlDataAdapter(sqlCommand);
                this.dataAdapter.Fill(this.tablaPersonas);

                this.dataAdapter.InsertCommand = new SqlCommand("INSERT INTO [personas_bd].[dbo].[personas]" +
                    "(nombre,apellido,edad) VALUES (@p1, @p2, @p3)");
                this.dataAdapter.UpdateCommand = new SqlCommand("UPDATE [personas_bd].[dbo].[personas]" +
                     "(nombre, apellido, edad) VALUES (@p1, @p2, @p3) where id=@4");
                this.dataAdapter.DeleteCommand = new SqlCommand("DELETE from [personas_bd].[dbo].[personas]" +
                    " WHERE id=@4");

                this.dataAdapter.InsertCommand.Parameters.Add("@p1",SqlDbType.VarChar,50,"nombre");
                this.dataAdapter.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
                this.dataAdapter.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 50, "edad");
                this.dataAdapter.InsertCommand.Parameters.Add("@p4", SqlDbType.Int, 50, "id");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                TextReader textReader = new StreamReader(open.FileName);
                this.lista = (List<Persona>)xml.Deserialize(textReader);
                textReader.Close();

            }
            catch
            {
            }
            //implementar...
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                SaveFileDialog open = new SaveFileDialog();
                open.ShowDialog();
                TextWriter streamWriter = new StreamWriter(open.FileName);
                xml.Serialize(streamWriter, lista);
                streamWriter.Close();
            }
            catch
            {
            }
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.lstVisor.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                frm.lstVisor.Items.Add(lista[i].ToString());
            }


            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar

            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                
                MessageBox.Show("se conecto");
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;//voy a escribir codigo de sql sobre el comando
                command.CommandText = "SELECT TOP 1000 [id]" +
                                              ",[nombre]" +
                                              ",[apellido]" +
                                              ",[edad]" +
                                         "FROM[personas_bd].[dbo].[personas]";
                conexion.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read() != false)
                {
                    MessageBox.Show(dataReader[0].ToString() +
                        dataReader[1].ToString() +
                        dataReader[2].ToString() +
                        dataReader[3].ToString());//o indice o nombre de la columna
                }
                dataReader.Close();
                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
           
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;//voy a escribir codigo de sql sobre el comando
                command.CommandText = "SELECT TOP 1000 [id]" +
                                              ",[nombre]" +
                                              ",[apellido]" +
                                              ",[edad]" +
                                         "FROM[personas_bd].[dbo].[personas]";
                conexion.Open();
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read() != false)
                {
                    Persona p = new Persona(dataReader[1].ToString(), dataReader[2].ToString(),
                        Convert.ToInt32(dataReader[3]));
                    this.lista.Add(p);
                }

                dataReader.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmVisorDataTable frmDataTable = new FrmVisorDataTable(this.tablaPersonas);
            frmDataTable.ShowDialog();
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataAdapter.Update(tablaPersonas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
