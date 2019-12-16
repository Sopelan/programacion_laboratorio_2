namespace sql_2
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
            this.id_textBox1 = new System.Windows.Forms.TextBox();
            this.Nombre_textBox2 = new System.Windows.Forms.TextBox();
            this.Apellido_textBox3 = new System.Windows.Forms.TextBox();
            this.id_label1 = new System.Windows.Forms.Label();
            this.Nombre_label2 = new System.Windows.Forms.Label();
            this.Apellido_label3 = new System.Windows.Forms.Label();
            this.Agregar_button1 = new System.Windows.Forms.Button();
            this.Eliminar_button2 = new System.Windows.Forms.Button();
            this.Modificar_button3 = new System.Windows.Forms.Button();
            this.Eliminar_radioButton2 = new System.Windows.Forms.RadioButton();
            this.Modificar_radioButton3 = new System.Windows.Forms.RadioButton();
            this.Registrar_radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_textBox1
            // 
            this.id_textBox1.Location = new System.Drawing.Point(267, 184);
            this.id_textBox1.Name = "id_textBox1";
            this.id_textBox1.Size = new System.Drawing.Size(230, 20);
            this.id_textBox1.TabIndex = 0;
            this.id_textBox1.TextChanged += new System.EventHandler(this.id_textBox1_TextChanged);
            // 
            // Nombre_textBox2
            // 
            this.Nombre_textBox2.Location = new System.Drawing.Point(267, 223);
            this.Nombre_textBox2.Name = "Nombre_textBox2";
            this.Nombre_textBox2.Size = new System.Drawing.Size(230, 20);
            this.Nombre_textBox2.TabIndex = 1;
            // 
            // Apellido_textBox3
            // 
            this.Apellido_textBox3.Location = new System.Drawing.Point(267, 264);
            this.Apellido_textBox3.Name = "Apellido_textBox3";
            this.Apellido_textBox3.Size = new System.Drawing.Size(230, 20);
            this.Apellido_textBox3.TabIndex = 2;
            // 
            // id_label1
            // 
            this.id_label1.AutoSize = true;
            this.id_label1.Location = new System.Drawing.Point(31, 182);
            this.id_label1.Name = "id_label1";
            this.id_label1.Size = new System.Drawing.Size(15, 13);
            this.id_label1.TabIndex = 3;
            this.id_label1.Text = "id";
            // 
            // Nombre_label2
            // 
            this.Nombre_label2.AutoSize = true;
            this.Nombre_label2.Location = new System.Drawing.Point(31, 220);
            this.Nombre_label2.Name = "Nombre_label2";
            this.Nombre_label2.Size = new System.Drawing.Size(44, 13);
            this.Nombre_label2.TabIndex = 4;
            this.Nombre_label2.Text = "Nombre";
            // 
            // Apellido_label3
            // 
            this.Apellido_label3.AutoSize = true;
            this.Apellido_label3.Location = new System.Drawing.Point(31, 264);
            this.Apellido_label3.Name = "Apellido_label3";
            this.Apellido_label3.Size = new System.Drawing.Size(44, 13);
            this.Apellido_label3.TabIndex = 5;
            this.Apellido_label3.Text = "Apellido";
            // 
            // Agregar_button1
            // 
            this.Agregar_button1.Location = new System.Drawing.Point(551, 182);
            this.Agregar_button1.Name = "Agregar_button1";
            this.Agregar_button1.Size = new System.Drawing.Size(75, 23);
            this.Agregar_button1.TabIndex = 6;
            this.Agregar_button1.Text = "Agregar";
            this.Agregar_button1.UseVisualStyleBackColor = true;
            this.Agregar_button1.Click += new System.EventHandler(this.Agregar_button1_Click);
            // 
            // Eliminar_button2
            // 
            this.Eliminar_button2.Location = new System.Drawing.Point(551, 220);
            this.Eliminar_button2.Name = "Eliminar_button2";
            this.Eliminar_button2.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button2.TabIndex = 7;
            this.Eliminar_button2.Text = "Eliminar";
            this.Eliminar_button2.UseVisualStyleBackColor = true;
            // 
            // Modificar_button3
            // 
            this.Modificar_button3.Location = new System.Drawing.Point(551, 264);
            this.Modificar_button3.Name = "Modificar_button3";
            this.Modificar_button3.Size = new System.Drawing.Size(75, 23);
            this.Modificar_button3.TabIndex = 8;
            this.Modificar_button3.Text = "Modificar";
            this.Modificar_button3.UseVisualStyleBackColor = true;
            this.Modificar_button3.Click += new System.EventHandler(this.Modificar_button3_Click);
            // 
            // Eliminar_radioButton2
            // 
            this.Eliminar_radioButton2.AutoSize = true;
            this.Eliminar_radioButton2.Location = new System.Drawing.Point(267, 55);
            this.Eliminar_radioButton2.Name = "Eliminar_radioButton2";
            this.Eliminar_radioButton2.Size = new System.Drawing.Size(61, 17);
            this.Eliminar_radioButton2.TabIndex = 11;
            this.Eliminar_radioButton2.TabStop = true;
            this.Eliminar_radioButton2.Text = "Eliminar";
            this.Eliminar_radioButton2.UseVisualStyleBackColor = true;
            this.Eliminar_radioButton2.CheckedChanged += new System.EventHandler(this.Eliminar_radioButton2_CheckedChanged);
            // 
            // Modificar_radioButton3
            // 
            this.Modificar_radioButton3.AutoSize = true;
            this.Modificar_radioButton3.Location = new System.Drawing.Point(541, 55);
            this.Modificar_radioButton3.Name = "Modificar_radioButton3";
            this.Modificar_radioButton3.Size = new System.Drawing.Size(68, 17);
            this.Modificar_radioButton3.TabIndex = 12;
            this.Modificar_radioButton3.TabStop = true;
            this.Modificar_radioButton3.Text = "Modificar";
            this.Modificar_radioButton3.UseVisualStyleBackColor = true;
            this.Modificar_radioButton3.CheckedChanged += new System.EventHandler(this.Modificar_radioButton3_CheckedChanged);
            // 
            // Registrar_radioButton1
            // 
            this.Registrar_radioButton1.AutoSize = true;
            this.Registrar_radioButton1.Location = new System.Drawing.Point(34, 55);
            this.Registrar_radioButton1.Name = "Registrar_radioButton1";
            this.Registrar_radioButton1.Size = new System.Drawing.Size(67, 17);
            this.Registrar_radioButton1.TabIndex = 13;
            this.Registrar_radioButton1.TabStop = true;
            this.Registrar_radioButton1.Text = "Registrar";
            this.Registrar_radioButton1.UseVisualStyleBackColor = true;
            this.Registrar_radioButton1.CheckedChanged += new System.EventHandler(this.Registrar_radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(711, 245);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Registrar_radioButton1);
            this.Controls.Add(this.Modificar_radioButton3);
            this.Controls.Add(this.Eliminar_radioButton2);
            this.Controls.Add(this.Modificar_button3);
            this.Controls.Add(this.Eliminar_button2);
            this.Controls.Add(this.Agregar_button1);
            this.Controls.Add(this.Apellido_label3);
            this.Controls.Add(this.Nombre_label2);
            this.Controls.Add(this.id_label1);
            this.Controls.Add(this.Apellido_textBox3);
            this.Controls.Add(this.Nombre_textBox2);
            this.Controls.Add(this.id_textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_textBox1;
        private System.Windows.Forms.TextBox Nombre_textBox2;
        private System.Windows.Forms.TextBox Apellido_textBox3;
        private System.Windows.Forms.Label id_label1;
        private System.Windows.Forms.Label Nombre_label2;
        private System.Windows.Forms.Label Apellido_label3;
        private System.Windows.Forms.Button Agregar_button1;
        private System.Windows.Forms.Button Eliminar_button2;
        private System.Windows.Forms.Button Modificar_button3;
        private System.Windows.Forms.RadioButton Eliminar_radioButton2;
        private System.Windows.Forms.RadioButton Modificar_radioButton3;
        private System.Windows.Forms.RadioButton Registrar_radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

