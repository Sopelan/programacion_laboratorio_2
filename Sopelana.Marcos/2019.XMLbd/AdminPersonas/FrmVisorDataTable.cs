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
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable dataTable;
        public FrmVisorDataTable(DataTable dataTable) : base()
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.lstVisor.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                lstVisor.Items.Add(this.dataTable.Rows[i][0].ToString() + this.dataTable.Rows[i][1].ToString() + this.dataTable.Rows[i][2].ToString() + this.dataTable.Rows[i][3].ToString());
            }

        }
        public DataTable DataTable { get { return dataTable; } }

        private void FrmVisorDataTable_Load(object sender, EventArgs e)
        {

        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                try
                {
                    string consulta = "INSERT INTO[personas_bd].[dbo].[personas](nombre,apellido,edad) VALUES(@nombre,@apellido,@edad)";
                    SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexion);
                    SqlCommand sqlCommand = new SqlCommand(consulta)
                    {
                        CommandType = CommandType.Text,
                        Connection = sql
                    };
                    sqlCommand.Parameters.AddWithValue("@nombre", frm.Persona.nombre);
                    sqlCommand.Parameters.AddWithValue("@apellido", frm.Persona.apellido);
                    sqlCommand.Parameters.AddWithValue("@edad", frm.Persona.edad.ToString());
                    sql.Open();
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                }
                catch (Exception message)
                {
                    Console.WriteLine(message.Message);
                }
                this.dataTable.Rows.Add();
                this.lstVisor.Items.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    lstVisor.Items.Add(dataTable.Rows[i][0].ToString() + dataTable.Rows[i][1].ToString() + dataTable.Rows[i][2].ToString() + dataTable.Rows[i][3].ToString());
                }
            }



            //implementar

        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);

            frm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                int j = this.lstVisor.SelectedIndex;
                frm.txtNombre.Text = dataTable.Rows[j][1].ToString();
                frm.txtApellido.Text = dataTable.Rows[j][2].ToString();
                frm.txtEdad.Text = dataTable.Rows[j][3].ToString();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    dataTable.Rows[j][1] = frm.txtNombre.Text;
                    dataTable.Rows[j][2] = frm.txtApellido.Text;
                    dataTable.Rows[j][3] = frm.txtEdad.Text;
                    this.lstVisor.Items.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        lstVisor.Items.Add(dataTable.Rows[i][0].ToString() + dataTable.Rows[i][1].ToString() + dataTable.Rows[i][2].ToString() + dataTable.Rows[i][3].ToString());
                    }
                }

            }
            catch
            {
                btnModificar.Enabled = false;
            }

            //implementar
        }
        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                int j = this.lstVisor.SelectedIndex;
                frm.txtNombre.Text = dataTable.Rows[j][1].ToString();
                frm.txtApellido.Text = dataTable.Rows[j][2].ToString();
                frm.txtEdad.Text = dataTable.Rows[j][3].ToString();
                frm.txtNombre.Enabled = false;
                frm.txtApellido.Enabled = false;
                frm.txtEdad.Enabled = false;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    dataTable.Rows.RemoveAt(j);
                    this.lstVisor.Items.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        lstVisor.Items.Add(dataTable.Rows[i][0].ToString() + dataTable.Rows[i][1].ToString() + dataTable.Rows[i][2].ToString() + dataTable.Rows[i][3].ToString());
                    }
                }

            }
            catch
            {
                btnEliminar.Enabled = false;
            }
        }
    }
}
