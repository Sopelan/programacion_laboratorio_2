namespace clase_06
{
    partial class cuadro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantPalabras = new System.Windows.Forms.Label();
            this.lblCantFinalizaLA = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rtxtTexto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subcadena\"A \"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Palabras";
            // 
            // lblCantPalabras
            // 
            this.lblCantPalabras.AutoSize = true;
            this.lblCantPalabras.Location = new System.Drawing.Point(97, 29);
            this.lblCantPalabras.Name = "lblCantPalabras";
            this.lblCantPalabras.Size = new System.Drawing.Size(13, 13);
            this.lblCantPalabras.TabIndex = 3;
            this.lblCantPalabras.Text = "0";
            // 
            // lblCantFinalizaLA
            // 
            this.lblCantFinalizaLA.AutoSize = true;
            this.lblCantFinalizaLA.Location = new System.Drawing.Point(97, 62);
            this.lblCantFinalizaLA.Name = "lblCantFinalizaLA";
            this.lblCantFinalizaLA.Size = new System.Drawing.Size(13, 13);
            this.lblCantFinalizaLA.TabIndex = 4;
            this.lblCantFinalizaLA.Text = "0";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 120);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(776, 20);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "3 primeras \"o \"";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "3 primeras \"a \"";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "100 letras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "20 palabras";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.FormattingEnabled = true;
            this.rtxtTexto.Location = new System.Drawing.Point(12, 200);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(776, 238);
            this.rtxtTexto.TabIndex = 10;
            // 
            // cuadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblCantFinalizaLA);
            this.Controls.Add(this.lblCantPalabras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cuadro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantPalabras;
        private System.Windows.Forms.Label lblCantFinalizaLA;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox rtxtTexto;
    }
}

