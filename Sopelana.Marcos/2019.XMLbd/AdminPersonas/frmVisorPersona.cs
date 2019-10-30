using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        public List<Persona> lista;
        public frmVisorPersona()
        {
            InitializeComponent();
        }
        public frmVisorPersona(List<Persona> persona):this()
        {
            this.lista = persona;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                    this.lista.Add(frm.Persona);
                    this.lstVisor.Items.Clear();
                    for(int i = 0; i < lista.Count;i++)
                    {
                        this.lstVisor.Items.Add(lista[i].ToString());
                    }
            }
            
            
            
            //implementar

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.lstVisor.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                this.lstVisor.Items.Add(lista[i].ToString());
            }
            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            this.lstVisor.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                this.lstVisor.Items.Add(lista[i].ToString());
            }
            //implementar
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
