using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;
namespace Clase_04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            Cosa c;
            c = new Cosa(textBox2.Text, Convert.ToDateTime(textBox3.Text), Convert.ToInt32(textBox1.Text));
            MessageBox.Show(c.Mostrar());
            listBox1.Items.Add(c.Mostrar());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
