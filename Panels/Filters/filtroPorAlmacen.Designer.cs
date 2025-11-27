namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroPorAlmacen
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
            label1 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // cbAlmacenes
            // 
            cbAlmacenes.FormattingEnabled = true;
            cbAlmacenes.Location = new Point(111, 101);
            cbAlmacenes.Name = "cbAlmacenes";
            cbAlmacenes.Size = new Size(143, 23);
            cbAlmacenes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 72);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Almacen";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(144, 154);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // filtroPorAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(cbAlmacenes);
            Name = "filtroPorAlmacen";
            Size = new Size(400, 291);
            Load += filtroPorAlmacen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAlmacenes;
        private Label label1;
        private Button btnBuscar;
    }
}
