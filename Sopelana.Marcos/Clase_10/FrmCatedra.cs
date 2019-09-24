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
    public partial class FrmCatedra : Form
    {

        private Catedra cat = new Catedra();
        private List<AlumnoCalificado> alumnoCalificado = new List<AlumnoCalificado>();
        public FrmCatedra()
        {
            InitializeComponent();
            this.Text = "FrmCatedra";
            this.modificar.Enabled = false;
            foreach(EtipoDeOrdenamiento c in Enum.GetValues(typeof(EtipoDeOrdenamiento)))
            {
                this.ordenar.Items.Add(c);
            }
            this.ordenar.SelectedItem = EtipoDeOrdenamiento.LegajoAscendente;
            this.ordenar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frm = new FrmAlumno();
            frm.Show();
            if (frm.DialogResult == DialogResult.OK)
            {
                if (cat + frm.Alum)
                    ActualizarListadoAlumnos();
            }

        }
        private void ActualizarListadoAlumnos()
        {
            this.lista.Items.Clear();
            foreach (Alumno a in this.cat.Alumnos)
            {
                this.lista.Items.Add(Alumno.Mostrar(a));
            }
        }
    }
}
