using System;
using System.Windows.Forms;
using Clase._06.Entidades;
namespace Clase_07
{
    public partial class Form1 : Form
    {
        private Paleta paleta;

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
            paleta = 5;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form form = new form();

            //form.MdiParent = this;
            form.ShowDialog();
            this.paleta += form.Tempera_GetSet;
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBoxPaleta.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.paleta);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
