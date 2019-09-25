namespace Clase_10
{
    partial class FrmCatedra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.calificar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordenar = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calificados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // calificar
            // 
            this.calificar.Location = new System.Drawing.Point(290, 27);
            this.calificar.Name = "calificar";
            this.calificar.Size = new System.Drawing.Size(75, 23);
            this.calificar.TabIndex = 1;
            this.calificar.Text = "Calificar";
            this.calificar.UseVisualStyleBackColor = true;
            this.calificar.Click += new System.EventHandler(this.calificar_button);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(577, 27);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(6, 56);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(646, 212);
            this.lista.TabIndex = 3;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lista.DoubleClick += new System.EventHandler(this.modificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ordenar);
            this.groupBox1.Controls.Add(this.calificar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lista);
            this.groupBox1.Controls.Add(this.modificar);
            this.groupBox1.Location = new System.Drawing.Point(59, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ordenar
            // 
            this.ordenar.FormattingEnabled = true;
            this.ordenar.Location = new System.Drawing.Point(6, 274);
            this.ordenar.Name = "ordenar";
            this.ordenar.Size = new System.Drawing.Size(646, 21);
            this.ordenar.TabIndex = 5;
            this.ordenar.SelectedIndexChanged += new System.EventHandler(this.ordenar_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calificados);
            this.groupBox2.Location = new System.Drawing.Point(65, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alumnos Calificados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listBox2
            // 
            this.calificados.FormattingEnabled = true;
            this.calificados.Location = new System.Drawing.Point(18, 20);
            this.calificados.Name = "listBox2";
            this.calificados.Size = new System.Drawing.Size(641, 277);
            this.calificados.TabIndex = 0;
            this.calificados.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCatedra";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calificar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ordenar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox calificados;
    }
}