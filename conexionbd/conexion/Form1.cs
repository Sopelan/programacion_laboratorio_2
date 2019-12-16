using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            string cadena = "SELECT id, concat(nombre,' ' ,apellido) as nombre FROM Table_1";
            SqlCommand command = new SqlCommand(cadena, conexion.connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "nombre";
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach(DataRow row in dataTable.Rows)
            {
                collection.Add(row["nombre"].ToString());
            }
            comboBox1.AutoCompleteCustomSource = collection;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //string cadena = "INSERT INTO Table_1(id,nombre,apellido) VALUES (@id,@nombre,@apellido)";
            //try
            //{
            //    SqlCommand command = new SqlCommand(cadena, conexion.connection);
            //    command.Parameters.AddWithValue("@id", 4);
            //    command.Parameters.AddWithValue("@nombre", "Juan");
            //    command.Parameters.AddWithValue("@apellido", "Perez");
            //    command.ExecuteNonQuery();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //string cadena = "SELECT * FROM Table_1";
            //SqlCommand command = new SqlCommand(cadena, conexion.connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //this.dataGridView1.DataSource = dataTable;
            //this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            //this.dataGridView1.Columns[0].Visible = false;

            //string cadena = "SELECT * FROM Table_1";
            //try
            //{
            //    SqlCommand comando = new SqlCommand(cadena, conexion.connection);
            //    SqlDataReader lector = comando.ExecuteReader();
            //    while(lector.Read())
            //    {
            //        MessageBox.Show(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString()+ "\n");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
