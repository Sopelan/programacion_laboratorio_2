using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_26.Entidades;
namespace Clase_26.WindowsForms
{
    public partial class Form1 : Form
    {
        public Empleado empleado;
        public Form1()
        {
            InitializeComponent();
            foreach(TipoManejador c in Enum.GetValues(typeof(TipoManejador)))
            {
                this.comboBox1.Items.Add(c);
            }
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedItem = TipoManejador.Todos;
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                empleado = new Empleado(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text));
                empleado.LimiteSueldo += new LimiteSueldoDelegado(empleado.ManejadorLimiteSueldo);
                empleado.LimiteSueldoMejorado += new LimiteSueldoMejoradoDel(Empleado.ManejadorLimiteSueldoMejorado);
                empleado.Sueldo = Convert.ToDouble(this.textBox4.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.comboBox1.SelectedItem = TipoManejador.Todos;
            this.Close();
        }
    }
}
