using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_2
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        public Form1()
        {
            InitializeComponent();
            this.Eliminar_button2.Enabled = false;
            this.Modificar_button3.Enabled = false;
            this.Agregar_button1.Enabled = false;
            this.id_textBox1.Enabled = false;
            this.Nombre_textBox2.Enabled = false;
            this.Apellido_textBox3.Enabled = false;
        }

        private void Registrar_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Eliminar_button2.Enabled = false;
            this.Modificar_button3.Enabled = false;
            this.Agregar_button1.Enabled = true;
            this.id_textBox1.Enabled = true;
            this.Nombre_textBox2.Enabled = true;
            this.Apellido_textBox3.Enabled = true;
        }

        private void Eliminar_radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Eliminar_button2.Enabled = true;
            this.Modificar_button3.Enabled = false;
            this.Agregar_button1.Enabled = false;
            this.id_textBox1.Enabled = false;
            this.Nombre_textBox2.Enabled = false;
            this.Apellido_textBox3.Enabled = false;
        }

        private void Modificar_radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Eliminar_button2.Enabled = false;
            this.Modificar_button3.Enabled = false;
            this.Agregar_button1.Enabled = false;
            this.id_textBox1.Enabled = true;
            this.Nombre_textBox2.Enabled = true;
            this.Apellido_textBox3.Enabled = true;
        }

        private void Agregar_button1_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(id_textBox1.Text)) == 0)
            {
                MessageBox.Show(this.c.insertar(Convert.ToInt32(this.id_textBox1.Text), this.Nombre_textBox2.Text, this.Apellido_textBox3.Text));
                this.id_textBox1.Clear();
                this.Nombre_textBox2.Clear();
                this.Apellido_textBox3.Clear();
                this.c.cargarPersonas(this.dataGridView1);
            }
            else
                MessageBox.Show("ya existe el ID");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c.cargarPersonas(this.dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void id_textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.Modificar_radioButton3.Checked == true)
            {
                try
                {
                    if (this.c.personaRegistrada(Convert.ToInt32(id_textBox1.Text)) > 0)
                    {
                        this.c.LlenarTextBoxConsulta(Convert.ToInt32(this.id_textBox1.Text), this.Nombre_textBox2, this.Apellido_textBox3);
                        this.Modificar_button3.Enabled = true;
                    }
                    else
                    {
                        this.Nombre_textBox2.Clear();
                        this.Apellido_textBox3.Clear();
                        this.Modificar_button3.Enabled = false;
                    }
                }
                catch
                {

                }
                
            }
        }

        private void Modificar_button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.c.actualizar(Convert.ToInt32(this.id_textBox1.Text), this.Nombre_textBox2.Text, this.Apellido_textBox3.Text));
            this.c.cargarPersonas(this.dataGridView1);
        }
    }
}
