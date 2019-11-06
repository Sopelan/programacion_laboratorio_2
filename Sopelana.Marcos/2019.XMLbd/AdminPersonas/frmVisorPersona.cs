using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Data.SqlClient;
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        public List<Persona> lista;
        
        public frmVisorPersona()
        {
            InitializeComponent();
        }
        public frmVisorPersona(List<Persona> persona):this()
        {
            this.lista = persona;
        }

       public virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        string consulta = "INSERT INTO[personas_bd].[dbo].[personas](nombre,apellido,edad) VALUES(@nombre,@apellido,@edad)";
                        SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                        SqlCommand sqlCommand = new SqlCommand(consulta);
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sql;
                        sqlCommand.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                        sqlCommand.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                        sqlCommand.Parameters.AddWithValue("@edad", frm.Persona.edad.ToString());
                        sql.Open();
                        sqlCommand.ExecuteNonQuery();
                        sql.Close();
                    }
                    catch(Exception message)
                    {
                        Console.WriteLine(message.Message); 
                    }

                    this.lstVisor.Items.Clear();
                    for(int i = 0; i < lista.Count;i++)
                    {
                        this.lstVisor.Items.Add(lista[i].ToString());
                    }
                }
            
            
            
            //implementar

        }

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            
            frm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                int j = this.lstVisor.SelectedIndex;
                frm.txtNombre.Text = this.lista[j].nombre;
                frm.txtApellido.Text = this.lista[j].apellido;
                frm.txtEdad.Text = this.lista[j].edad.ToString();
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        string consulta = "UPDATE [personas_bd].[dbo].[personas](nombre,apellido,edad) SET(@nombre,@apellido,@edad)WHERE id = (@id)";
                        SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                        SqlCommand sqlCommand = new SqlCommand(consulta);
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = sql;
                        sqlCommand.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                        sqlCommand.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                        sqlCommand.Parameters.AddWithValue("@edad", frm.Persona.edad.ToString());
                        sqlCommand.Parameters.AddWithValue("@id",lstVisor.SelectedItem);
                        sql.Open();
                        sqlCommand.ExecuteNonQuery();
                        sql.Close();
                    }
                    catch (Exception message)
                    {
                        Console.WriteLine(message.Message);
                    }
                    this.lista[j] = frm.Persona;
                    this.lstVisor.Items.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        this.lstVisor.Items.Add(lista[i].ToString());
                    }
                }
               
            }
            catch
            {
                btnModificar.Enabled = false;
            }

            //implementar
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                int j = this.lstVisor.SelectedIndex;
                frm.txtNombre.Text = this.lista[j].nombre;
                frm.txtApellido.Text = this.lista[j].apellido;
                frm.txtEdad.Text = this.lista[j].edad.ToString();
                frm.txtNombre.Enabled = false;
                frm.txtApellido.Enabled = false;
                frm.txtEdad.Enabled = false;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    this.lista.RemoveAt(j);
                    this.lstVisor.Items.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        this.lstVisor.Items.Add(lista[i].ToString());
                    }
                }

            }
            catch
            {
                btnEliminar.Enabled = false;
            }
            //implementar
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
