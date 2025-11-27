namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class filtroRangoPrecio
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
            txtPrecioMenor = new TextBox();
            txtPrecioMayor = new TextBox();
            btnBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPrecioMenor
            // 
            txtPrecioMenor.Location = new Point(81, 83);
            txtPrecioMenor.Name = "txtPrecioMenor";
            txtPrecioMenor.Size = new Size(100, 23);
            txtPrecioMenor.TabIndex = 0;
            txtPrecioMenor.Text = "0";
            // 
            // txtPrecioMayor
            // 
            txtPrecioMayor.Location = new Point(220, 83);
            txtPrecioMayor.Name = "txtPrecioMayor";
            txtPrecioMayor.Size = new Size(100, 23);
            txtPrecioMayor.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(157, 182);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 58);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Valor menor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 58);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Valor mayor";
            // 
            // filtroRangoPrecio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(txtPrecioMayor);
            Controls.Add(txtPrecioMenor);
            Name = "filtroRangoPrecio";
            Size = new Size(400, 291);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecioMenor;
        private TextBox txtPrecioMayor;
        private Button btnBuscar;
        private Label label1;
        private Label label2;
    }
}
