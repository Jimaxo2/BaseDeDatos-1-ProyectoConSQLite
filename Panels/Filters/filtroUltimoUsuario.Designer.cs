namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroUltimoUsuario
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
            cbUsuarios = new ComboBox();
            btnBuscar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbUsuarios
            // 
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(102, 95);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(178, 23);
            cbUsuarios.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(154, 149);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 67);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 3;
            label1.Text = "Selecciona el usuario a consultar";
            // 
            // filtroUltimoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(cbUsuarios);
            Name = "filtroUltimoUsuario";
            Size = new Size(400, 291);
            Load += filtroUltimoUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbUsuarios;
        private Button btnBuscar;
        private Label label1;
    }
}
