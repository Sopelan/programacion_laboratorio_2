using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_12y14.Entidades;
namespace Clase_14
{
    public partial class frmLlamada : Form
    {
        protected Llamada miLlamada;
        private Llamada MiLlamada { get { return miLlamada; } }
        public frmLlamada()
        {
            InitializeComponent();
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmLlamada_Load(object sender, EventArgs e)
        {

        }
    }
}
