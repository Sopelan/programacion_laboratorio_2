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

using Entidades;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> listaAux;
        SqlConnection conexion;

        public frmVisorPersona()
        {
            InitializeComponent();
            this.listaAux = new List<Persona>();

            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        public frmVisorPersona(List<Persona> l) : this()
        {
            this.listaAux = l;
        }

        public List<Persona> Lista
        {
            get
            {
                return this.listaAux;
            }
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)//pasar obj a db
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                this.listaAux.Add(frm.Persona);
                this.lstVisor.Items.Clear();
                for (int i = 0; i < listaAux.Count; i++)
                {
                    this.lstVisor.Items.Add(listaAux[i].ToString());

                    this.conexion = new SqlConnection(Properties.Settings.Default.Conexion);

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conexion;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into [personas_bd].[dbo].[personas] " +
                            "(nombre,apellido,edad) VALUES (@nombre, @apellido, @edad)";
                        command.Parameters.AddWithValue("@nombre", listaAux[i].nombre);
                        command.Parameters.AddWithValue("@apellido", listaAux[i].apellido);
                        command.Parameters.AddWithValue("@edad", listaAux[i].edad.ToString());

                        conexion.Open();

                        command.ExecuteNonQuery();
                    }
                }
            }

            //object persona = frm.Persona;

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstVisor.SelectedIndex;
            frmPersona frm = new frmPersona(/*params*/);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.listaAux[selectedIndex] = frm.Persona;
                this.lstVisor.Items.Clear();
                for (int i = 0; i < listaAux.Count; i++)
                {
                    this.lstVisor.Items.Add(listaAux[i].ToString());
                }
            }

            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //frm.ShowDialog();

            int selectedIndex = this.lstVisor.SelectedIndex;//esta mal usar selected index



            //if (frm.DialogResult == DialogResult.OK)
            //{
                this.listaAux.RemoveAt(selectedIndex);
                this.lstVisor.Items.Clear();
                for (int i = 0; i < listaAux.Count; i++)
                {
                    this.lstVisor.Items.Add(listaAux[i].ToString());
                }
            //}

            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if(this.lstVisor.SelectedIndex >= 0)
            {
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.btnModificar.Enabled = false;
                this.btnEliminar.Enabled = false;
            }

            this.btnModificar.Click -= new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click -= new System.EventHandler(this.btnEliminar_Click);

            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        }
    }
}
