namespace Clase_10
{
    partial class FrmAlumnoCalificado
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
            this.label5 = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // legajo
            // 
            this.legajo.Location = new System.Drawing.Point(39, 204);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(42, 132);
            // 
            // tipoExamen
            // 
            this.tipoExamen.Location = new System.Drawing.Point(36, 281);
            this.tipoExamen.SelectedIndexChanged += new System.EventHandler(this.tipoExamen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Nota
            // 
            this.Nota.Location = new System.Drawing.Point(36, 370);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(211, 20);
            this.Nota.TabIndex = 11;
            this.Nota.TextChanged += new System.EventHandler(this.Nota_TextChanged);
            // 
            // FrmAlumnoCalificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 514);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.label5);
            this.Name = "FrmAlumnoCalificado";
            this.Text = "FrmAlumnoCalificado";
            this.Load += new System.EventHandler(this.FrmAlumnoCalificado_Load);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.apellido, 0);
            this.Controls.SetChildIndex(this.legajo, 0);
            this.Controls.SetChildIndex(this.tipoExamen, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Nota, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nota;
    }
}