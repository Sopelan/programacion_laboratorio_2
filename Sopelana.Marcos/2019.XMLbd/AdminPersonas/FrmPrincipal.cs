using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;
        public List<Persona> Lista{get{return lista;} set { lista = value; } }
        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                TextReader textReader = new StreamReader(open.FileName);
                this.lista = (List<Persona>)xml.Deserialize(textReader);
                textReader.Close();

            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);

            }
            //implementar...
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                SaveFileDialog open = new SaveFileDialog();
                open.ShowDialog();
                TextWriter streamWriter = new StreamWriter(open.FileName);
                xml.Serialize(streamWriter, lista);
                streamWriter.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            //implementar...
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.lstVisor.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                frm.lstVisor.Items.Add(lista[i].ToString());
            }
            frm.ShowDialog();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
