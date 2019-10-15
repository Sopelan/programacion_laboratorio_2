namespace clase_15.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombreArchivo = new System.Windows.Forms.Label();
            this.textBoxNombreArchivo = new System.Windows.Forms.TextBox();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.comboBoxUbicacion = new System.Windows.Forms.ComboBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreArchivo
            // 
            this.labelNombreArchivo.AutoSize = true;
            this.labelNombreArchivo.Location = new System.Drawing.Point(12, 9);
            this.labelNombreArchivo.Name = "labelNombreArchivo";
            this.labelNombreArchivo.Size = new System.Drawing.Size(103, 13);
            this.labelNombreArchivo.TabIndex = 0;
            this.labelNombreArchivo.Text = "Nombre del Archivo:";
            // 
            // textBoxNombreArchivo
            // 
            this.textBoxNombreArchivo.Location = new System.Drawing.Point(12, 25);
            this.textBoxNombreArchivo.Name = "textBoxNombreArchivo";
            this.textBoxNombreArchivo.Size = new System.Drawing.Size(182, 20);
            this.textBoxNombreArchivo.TabIndex = 1;
            this.textBoxNombreArchivo.TextChanged += new System.EventHandler(this.textBoxNombreArchivo_TextChanged);
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(12, 48);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(58, 13);
            this.labelUbicacion.TabIndex = 2;
            this.labelUbicacion.Text = "Ubicacion:";
            // 
            // comboBoxUbicacion
            // 
            this.comboBoxUbicacion.FormattingEnabled = true;
            this.comboBoxUbicacion.Location = new System.Drawing.Point(12, 64);
            this.comboBoxUbicacion.Name = "comboBoxUbicacion";
            this.comboBoxUbicacion.Size = new System.Drawing.Size(182, 21);
            this.comboBoxUbicacion.TabIndex = 3;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(12, 88);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(37, 13);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = "Texto:";
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Location = new System.Drawing.Point(12, 104);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(182, 96);
            this.richTextBoxTexto.TabIndex = 5;
            this.richTextBoxTexto.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(12, 206);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(119, 206);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(75, 23);
            this.buttonLeer.TabIndex = 7;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 254);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.richTextBoxTexto);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.comboBoxUbicacion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.textBoxNombreArchivo);
            this.Controls.Add(this.labelNombreArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreArchivo;
        private System.Windows.Forms.TextBox textBoxNombreArchivo;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.ComboBox comboBoxUbicacion;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLeer;
    }
}

