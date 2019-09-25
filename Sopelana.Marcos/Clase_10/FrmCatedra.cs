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
            
            this.modificar.Enabled = true;
           
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
            FrmAlumno frm = new FrmAlumno();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                if (cat + frm.Alum)
                {
                    MessageBox.Show(Alumno.Mostrar(frm.Alum));
                    ActualizarListadoAlumnos();
                }
                   
                else
                    MessageBox.Show("Error mismo legajo");
            }

        }
        private void ActualizarListadoAlumnos()
        {
            this.modificar.Enabled = false;
            this.lista.Items.Clear();
            foreach (Alumno a in this.cat.Alumnos)
            {
                this.lista.Items.Add(Alumno.Mostrar(a));
            }
        }

        private void ordenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
            switch (ordenar.SelectedItem)
            {
                case EtipoDeOrdenamiento.LegajoAscendente:
                    this.cat.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case EtipoDeOrdenamiento.LegajoDescendente:
                    this.cat.Alumnos.Sort(Alumno.OrdenarPorLegajoDec);
                    break;
                case EtipoDeOrdenamiento.ApellidoAscendente:
                    this.cat.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case EtipoDeOrdenamiento.ApellidoDescendente:
                    this.cat.Alumnos.Sort(Alumno.OrdenarPorApellidoDec);
                    break;
            }
            this.ActualizarListadoAlumnos();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            int index = this.lista.SelectedIndex;
            if(this.lista.Enabled == true && index >= 0)
            {
                FrmAlumno frm = new FrmAlumno();
                frm.legajo.Text = cat.Alumnos[index].Legajo.ToString();
                frm.nombre.Text = cat.Alumnos[index].Nombre;
                frm.apellido.Text = cat.Alumnos[index].Apellido;
                frm.tipoExamen.Text = cat.Alumnos[index].Examen.ToString();
                frm.legajo.Enabled = false;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    cat.Alumnos[index] = frm.Alum;
                    ActualizarListadoAlumnos();
                }

            }

        }

        private void calificar_button(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
            int index = this.lista.SelectedIndex;
            if (this.lista.Enabled == true && index >= 0 )
            {
                FrmAlumnoCalificado frm = new FrmAlumnoCalificado();
                frm.legajo.Text = cat.Alumnos[index].Legajo.ToString();
                frm.nombre.Text = cat.Alumnos[index].Nombre;
                frm.apellido.Text = cat.Alumnos[index].Apellido;
                frm.tipoExamen.Text = cat.Alumnos[index].Examen.ToString();
                frm.legajo.Enabled = false;
                frm.nombre.Enabled = false;
                frm.apellido.Enabled = false;
                frm.tipoExamen.Enabled = false;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {

                    if (this.cat - frm.Alum)
                    {
                        ActualizarListadoAlumnos();
                        this.alumnoCalificado.Add(frm.alumCalificado);
                        this.calificados.Items.Add(frm.alumCalificado.Mostrar());
                    }


                    
                }
                
            }
           

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.modificar.Enabled = false;
        }
    }
}
