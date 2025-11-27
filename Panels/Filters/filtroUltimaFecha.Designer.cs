namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroUltimaFecha
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
            mcCalendario = new MonthCalendar();
            btnBuscar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(73, 51);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(160, 225);
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
            label1.Location = new Point(76, 28);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecciona la fecha deseada";
            // 
            // filtroUltimaFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(mcCalendario);
            Name = "filtroUltimaFecha";
            Size = new Size(400, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcCalendario;
        private Button btnBuscar;
        private Label label1;
    }
}
