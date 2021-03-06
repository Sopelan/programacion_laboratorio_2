﻿using System;
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
    public partial class frmPersona : Form
    {
        private Persona miPersona;

        public Persona Persona
        {
            get { return this.miPersona; }
            
        }

        public frmPersona()
        {
            InitializeComponent();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.miPersona = new Persona(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("ingrese valores validos");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
