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
using Entidades;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        public List<Persona> Lista{get{return lista;} set { lista = value; } }
        DataTable TablaPersonas;
        
        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
            
        }
        public void cargarDataTable()
        {
            SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sql;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT TOP 1000 [id] ,[nombre] ,[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
            SqlDataReader dataReader;
            dataReader = sqlCommand.ExecuteReader();
            this.TablaPersonas.Load(dataReader);
            sql.Close();
            sqlCommand.Clone();
            dataReader.Close();
        }
        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = @"D:\VisualStudio\programacion_laboratorio_2\Sopelana.Marcos\2019.XMLbd";
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
                open.InitialDirectory = @"D:\VisualStudio\programacion_laboratorio_2\Sopelana.Marcos\2019.XMLbd";
                open.ShowDialog();
                TextWriter streamWriter = new StreamWriter(open.FileName);
                xml.Serialize(streamWriter, lista);
                streamWriter.Close();
            }
            catch
            {
                
            }
            //implementar...
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.lstVisor.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                frm.lstVisor.Items.Add(lista[i].ToString());
            }
            frm.ShowDialog();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                sql.Open();
                MessageBox.Show("se conecto");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sql;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TOP 1000 [id] ,[nombre] ,[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                SqlDataReader dataReader;
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read() != false)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i <= 3;i++)
                    {
                        sb.Append(dataReader[i] + " ");
                    }
                    MessageBox.Show(sb.ToString());
                }
                dataReader.Close();
                sql.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Clear();
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                sql.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sql;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TOP 1000 [id] ,[nombre] ,[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
                SqlDataReader dataReader;
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read() != false)
                {
                    lista.Add(new Persona(dataReader[1].ToString(), dataReader[2].ToString(), Convert.ToInt32(dataReader[3])));
                }
                dataReader.Close();
                sql.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaPersonas = new DataTable("personas");
            this.cargarDataTable();
            FrmVisorDataTable frm = new FrmVisorDataTable(this.TablaPersonas);
            frm.ShowDialog();
        }
    }
}
