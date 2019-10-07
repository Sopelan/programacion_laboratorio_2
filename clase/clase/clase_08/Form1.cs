using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Clase 8";
            Form2 form2 = new Form2();
            form2.ShowDialog();
            while(form2.DialogResult != DialogResult.OK)
                form2.ShowDialog();
            empresa = new Empresa(form2.txtRazonSocial.Text, form2.txtDireccion.Text,float.Parse(form2.mtxtGanancias.Text));
            foreach(Empleado.EPuestoJerarquico c in Enum.GetValues(typeof(Empleado.EPuestoJerarquico)))
            {
                cmbPuesto.Items.Add(c);
            }
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        Empresa empresa;
        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.mtxtLegajo.Text = "";
            this.cmbPuesto.Text = "";
            this.mtxtSalario.Text = "";
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            Empleado.EPuestoJerarquico ePuestoJerarquico = (Empleado.EPuestoJerarquico)cmbPuesto.SelectedItem;
            empleado = new Empleado(this.txtNombre.Text, this.txtApellido.Text, this.mtxtLegajo.Text, ePuestoJerarquico,Convert.ToInt32(this.mtxtSalario.Text));
            empresa += empleado;
            this.rtxtConsola.Items.Clear();
            foreach(Empleado em in empresa.NominaEmpleados)
            {
                this.rtxtConsola.Items.Add(em.Mostrar());
            }
                
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.txtRazonSocial.Text = empresa.RazonSocial;
            form2.txtDireccion.Text = empresa.Direccion;
            form2.mtxtGanancias.Text = empresa.Ganancias.ToString();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                empresa.RazonSocial = form2.txtRazonSocial.Text;
                empresa.Direccion = form2.txtDireccion.Text;
                empresa.Ganancias = Convert.ToInt32(form2.mtxtGanancias.Text);
            }
                
               


        }

    }
}
