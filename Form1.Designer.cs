namespace BaseDeDatos_SQLLite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pDisplay = new Panel();
            toolStrip1 = new ToolStrip();
            dspCatalogos = new ToolStripDropDownButton();
            inicioToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            almacenesToolStripMenuItem1 = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pDisplay
            // 
            pDisplay.Location = new Point(0, 28);
            pDisplay.Name = "pDisplay";
            pDisplay.Size = new Size(1006, 545);
            pDisplay.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Enabled = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { dspCatalogos });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1006, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.Visible = false;
            // 
            // dspCatalogos
            // 
            dspCatalogos.DropDownItems.AddRange(new ToolStripItem[] { inicioToolStripMenuItem1, productosToolStripMenuItem1, almacenesToolStripMenuItem1, cerrarSesionToolStripMenuItem });
            dspCatalogos.Image = Properties.Resources.catalogos;
            dspCatalogos.ImageTransparentColor = Color.Magenta;
            dspCatalogos.Name = "dspCatalogos";
            dspCatalogos.Size = new Size(89, 22);
            dspCatalogos.Text = "Catalogos";
            dspCatalogos.EnabledChanged += dspCatalogos_EnabledChanged;
            // 
            // inicioToolStripMenuItem1
            // 
            inicioToolStripMenuItem1.Name = "inicioToolStripMenuItem1";
            inicioToolStripMenuItem1.Size = new Size(142, 22);
            inicioToolStripMenuItem1.Text = "Inicio";
            inicioToolStripMenuItem1.Click += inicioToolStripMenuItem1_Click;
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(142, 22);
            productosToolStripMenuItem1.Text = "Productos";
            productosToolStripMenuItem1.Click += productosToolStripMenuItem1_Click;
            // 
            // almacenesToolStripMenuItem1
            // 
            almacenesToolStripMenuItem1.Name = "almacenesToolStripMenuItem1";
            almacenesToolStripMenuItem1.Size = new Size(142, 22);
            almacenesToolStripMenuItem1.Text = "Almacenes";
            almacenesToolStripMenuItem1.Click += almacenesToolStripMenuItem1_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(142, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 574);
            Controls.Add(toolStrip1);
            Controls.Add(pDisplay);
            MaximizeBox = false;
            MaximumSize = new Size(1022, 613);
            MinimumSize = new Size(1022, 613);
            Name = "Form1";
            Text = "Administrador de productos";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pDisplay;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dspCatalogos;
        private ToolStripMenuItem inicioToolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem almacenesToolStripMenuItem1;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}
