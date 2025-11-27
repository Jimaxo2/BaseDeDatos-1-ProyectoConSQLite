namespace BaseDeDatos_SQLLite.Panels
{
    partial class panelManejarAlmacenes
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
            txtNombreAlmacen = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 255);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del almacen";
            // 
            // txtNombreAlmacen
            // 
            txtNombreAlmacen.Location = new Point(329, 273);
            txtNombreAlmacen.Name = "txtNombreAlmacen";
            txtNombreAlmacen.Size = new Size(226, 23);
            txtNombreAlmacen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 191);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Almacen Id";
            // 
            // txtID
            // 
            txtID.Location = new Point(329, 209);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(84, 23);
            txtID.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(342, 337);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(443, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelManejarAlmacenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtNombreAlmacen);
            Controls.Add(label1);
            Name = "panelManejarAlmacenes";
            Size = new Size(1006, 545);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreAlmacen;
        private Label label2;
        private TextBox txtID;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
