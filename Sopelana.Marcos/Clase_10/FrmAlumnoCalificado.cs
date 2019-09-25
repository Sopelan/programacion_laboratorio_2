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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            
        }
        AlumnoCalificado alumnoCalificado;
        public AlumnoCalificado alumCalificado { get { return alumnoCalificado; } }
        private void FrmAlumnoCalificado_Load(object sender, EventArgs e)
        {

        }

        private void tipoExamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Nota_TextChanged(object sender, EventArgs e)
        {

        }
        public override void aceptar_Click(object sender, EventArgs e)
        {
            ETipoExamen ti = (ETipoExamen)tipoExamen.SelectedItem;
            Alum = new Alumno(nombre.Text, apellido.Text, Convert.ToInt32(legajo.Text), ti);
            alumnoCalificado = new AlumnoCalificado(Alum, Convert.ToDouble(this.Nota.Text));

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
