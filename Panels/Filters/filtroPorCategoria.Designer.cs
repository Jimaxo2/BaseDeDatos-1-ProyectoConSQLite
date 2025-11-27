namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroPorCategoria
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
            cbCategoria = new ComboBox();
            btnGuardar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(104, 93);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(171, 23);
            cbCategoria.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(153, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Buscar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 75);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Selcciona la categoria";
            // 
            // filtroPorCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(cbCategoria);
            Name = "filtroPorCategoria";
            Size = new Size(400, 291);
            Load += filtroPorCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCategoria;
        private Button btnGuardar;
        private Label label1;
    }
}
