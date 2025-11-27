namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class aFiltroPorNombre
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
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 89);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Igrese el nombre a buscar";
            // 
            // txtNombreAlmacen
            // 
            txtNombreAlmacen.Location = new Point(119, 107);
            txtNombreAlmacen.Name = "txtNombreAlmacen";
            txtNombreAlmacen.Size = new Size(147, 23);
            txtNombreAlmacen.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(149, 167);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // aFiltroPorNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscar);
            Controls.Add(txtNombreAlmacen);
            Controls.Add(label1);
            Name = "aFiltroPorNombre";
            Size = new Size(400, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreAlmacen;
        private Button btnBuscar;
    }
}
