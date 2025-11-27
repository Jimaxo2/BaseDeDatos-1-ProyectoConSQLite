namespace BaseDeDatos_SQLLite.Panels
{
    partial class panelManejarProductos
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
            cbAlmacenes = new ComboBox();
            label6 = new Label();
            txtDepartamento = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // cbAlmacenes
            // 
            cbAlmacenes.FormattingEnabled = true;
            cbAlmacenes.Location = new Point(122, 268);
            cbAlmacenes.Name = "cbAlmacenes";
            cbAlmacenes.Size = new Size(133, 23);
            cbAlmacenes.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 271);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 24;
            label6.Text = "Almacen:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(122, 225);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(276, 23);
            txtDepartamento.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 228);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 22;
            label5.Text = "Categoria:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(122, 180);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 183);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 20;
            label4.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(122, 137);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(418, 23);
            txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 17;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 16;
            label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(568, 423);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(662, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 62);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 28;
            label1.Text = "Id";
            // 
            // txtID
            // 
            txtID.Location = new Point(122, 59);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 29;
            // 
            // panelManejarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cbAlmacenes);
            Controls.Add(label6);
            Controls.Add(txtDepartamento);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "panelManejarProductos";
            Size = new Size(1006, 545);
            Load += panelManejarProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAlmacenes;
        private Label label6;
        private TextBox txtDepartamento;
        private Label label5;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtID;
    }
}
