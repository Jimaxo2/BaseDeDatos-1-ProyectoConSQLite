namespace BaseDeDatos_SQLLite.Panels
{
    partial class panelInicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            labelUsuarioActivo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(357, 481);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "Creado por: Jimmy Silva Luna\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UnisonLogo;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(332, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 82, 158);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 106);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 187, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 84);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.Image = Properties.Resources.BUHO_ABSTRACCION_EPN_big;
            pictureBox2.Location = new Point(415, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(492, 28);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 0;
            label2.Text = "Inicio";
            // 
            // labelUsuarioActivo
            // 
            labelUsuarioActivo.AutoSize = true;
            labelUsuarioActivo.Font = new Font("Segoe UI", 13F);
            labelUsuarioActivo.Location = new Point(357, 434);
            labelUsuarioActivo.Name = "labelUsuarioActivo";
            labelUsuarioActivo.Size = new Size(133, 25);
            labelUsuarioActivo.TabIndex = 8;
            labelUsuarioActivo.Text = "Usuario activo: ";
            // 
            // panelInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelUsuarioActivo);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "panelInicio";
            Size = new Size(1006, 545);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label labelUsuarioActivo;
    }
}
