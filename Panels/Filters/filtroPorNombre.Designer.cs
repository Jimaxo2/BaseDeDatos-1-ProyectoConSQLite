namespace BaseDeDatos_SQLLite.Panels.Filtros
{
    partial class filtroPorNombre
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
            txtNombreProducto = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 86);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(55, 114);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(266, 23);
            txtNombreProducto.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(153, 190);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // filtroPorNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscar);
            Controls.Add(txtNombreProducto);
            Controls.Add(label1);
            Name = "filtroPorNombre";
            Size = new Size(400, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreProducto;
        private Button btnBuscar;
    }
}
