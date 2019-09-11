using System;
using System.Windows.Forms;
using Clase._06.Entidades;
namespace Clase_07
{
    public partial class Form1 : Form
    {
        private Paleta paleta;
        int cantidad = 5;
        public Paleta Paletas
        {
            get { return paleta; }
            set { paleta = value; }
        }

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.groupBoxPaleta.Visible = false;
            
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form form = new form();
            //form.MdiParent = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                this.Paletas += form.Tempera_GetSet;
                string mensaje = (string)this.paleta;
                this.listBox1.Items.Add(mensaje);
            }
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Paletas = this.cantidad;
            this.groupBoxPaleta.Visible = true;
            this.paletaToolStripMenuItem.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form form = new form();
            //form.MdiParent = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                this.Paletas += form.Tempera_GetSet;
                string mensaje =(string) this.paleta;
                this.listBox1.Items.Add(mensaje);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form form = new form();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                this.Paletas -= form.Tempera_GetSet;
                string mensaje = (string)this.paleta;
                this.listBox1.Items.Add(mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
