﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase._06.Entidades;
namespace Clase_07
{
    public partial class form : Form
    {
        
        private Tempera tempera;   

        public Tempera Tempera_GetSet
        {
            get { return tempera; }
            set { tempera = value; }
        }

        public form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.color.Items.Add(c);
            }
            this.color.SelectedItem = ConsoleColor.Magenta;
            this.color.DropDownStyle = ComboBoxStyle.DropDownList;
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void aceptar_Click(object sender, EventArgs e)
        {
            
            ConsoleColor c =(ConsoleColor) this.color.SelectedItem;
            this.tempera = new Tempera( c, this.Marca.Text , int.Parse(this.cantidad.Text));
            Close();
            MessageBox.Show(this.tempera);
            this.DialogResult = DialogResult.OK;


        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
