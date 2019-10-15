using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace clase_15.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Environment.SpecialFolder sf in Enum.GetValues(typeof(Environment.SpecialFolder)))//"recorro" el enumerado
            {
                this.comboBoxUbicacion.Items.Add(sf);
            }
            this.comboBoxUbicacion.SelectedItem = Environment.SpecialFolder.Desktop;
            this.comboBoxUbicacion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Programacion\" + this.textBoxNombreArchivo.Text + ".txt"))//arreglar el path
                {
                    sw.Write(this.richTextBoxTexto.Text);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se ha podido guardar el archivo.");
            }
            
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Programacion\" + this.textBoxNombreArchivo.Text + ".txt"))
                {
                    string lines;
                    this.richTextBoxTexto.Clear();
                    do
                    {
                        lines = sr.ReadLine();
                        if (lines!= null)
                        {
                            this.richTextBoxTexto.AppendText(lines + "\n");
                        }
                            
                    } while (lines != null);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No se ha podido cargar el archivo.");
            }
        }

        private void textBoxNombreArchivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
