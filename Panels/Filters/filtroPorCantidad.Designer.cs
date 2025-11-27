namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroPorCantidad
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
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            txtCantidadMayor = new TextBox();
            txtCantidadMenor = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 11;
            label2.Text = "Valor mayor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 71);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 10;
            label1.Text = "Valor menor";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(152, 197);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCantidadMayor
            // 
            txtCantidadMayor.Location = new Point(220, 96);
            txtCantidadMayor.Name = "txtCantidadMayor";
            txtCantidadMayor.Size = new Size(100, 23);
            txtCantidadMayor.TabIndex = 7;
            // 
            // txtCantidadMenor
            // 
            txtCantidadMenor.Location = new Point(81, 96);
            txtCantidadMenor.Name = "txtCantidadMenor";
            txtCantidadMenor.Size = new Size(100, 23);
            txtCantidadMenor.TabIndex = 6;
            txtCantidadMenor.Text = "0";
            // 
            // filtroPorCantidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(txtCantidadMayor);
            Controls.Add(txtCantidadMenor);
            Name = "filtroPorCantidad";
            Size = new Size(400, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnBuscar;
        private TextBox txtCantidadMayor;
        private TextBox txtCantidadMenor;
    }
}
