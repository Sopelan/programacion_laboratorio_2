using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;
namespace Clase_10
{
    public partial class FrmAlumno : Form
    {
        private Alumno alum;
        public Alumno Alum { get { return alum; } }
        public FrmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen c in Enum.GetValues(typeof(ETipoExamen)))
            {
                tipoExamen.Items.Add(c);
            }
            tipoExamen.SelectedItem = ETipoExamen.Final;
            tipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            ETipoExamen ti = (ETipoExamen)tipoExamen.SelectedItem;
            alum = new Alumno(nombre.Text, apellido.Text, Convert.ToInt32(legajo.Text),ti );
            MessageBox.Show(Alumno.Mostrar(alum));
           this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
