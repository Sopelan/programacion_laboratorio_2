using System;
using System.Windows.Forms;
namespace Clase_10
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text = "FrmPrincipal";
            this.WindowState = FormWindowState.Maximized;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Catedra_Click(object sender, EventArgs e)
        {
            FrmCatedra frm = new FrmCatedra();
            frm.Show();
        }
    }
}
