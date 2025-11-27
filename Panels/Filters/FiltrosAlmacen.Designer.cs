namespace BaseDeDatos_SQLLite.Panels.Filters
{
    partial class FiltrosAlmacen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltrosAlmacen));
            pFiltros = new Panel();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsFiltrar = new ToolStripDropDownButton();
            porToolStripMenuItem = new ToolStripMenuItem();
            porNombreToolStripMenuItem = new ToolStripMenuItem();
            porFechaDeCreacionToolStripMenuItem = new ToolStripMenuItem();
            porUltimaVezModificadoToolStripMenuItem = new ToolStripMenuItem();
            porUltimoUsuarioQueModificoToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            pFiltros.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pFiltros
            // 
            pFiltros.Controls.Add(label1);
            pFiltros.Location = new Point(12, 27);
            pFiltros.Name = "pFiltros";
            pFiltros.Size = new Size(400, 291);
            pFiltros.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 139);
            label1.Name = "label1";
            label1.Size = new Size(219, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecciona una de las opciones de filtros";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsFiltrar, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(424, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsFiltrar
            // 
            tsFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porToolStripMenuItem, porNombreToolStripMenuItem, porFechaDeCreacionToolStripMenuItem, porUltimaVezModificadoToolStripMenuItem, porUltimoUsuarioQueModificoToolStripMenuItem });
            tsFiltrar.Image = (Image)resources.GetObject("tsFiltrar.Image");
            tsFiltrar.ImageTransparentColor = Color.Magenta;
            tsFiltrar.Name = "tsFiltrar";
            tsFiltrar.Size = new Size(50, 22);
            tsFiltrar.Text = "Filtrar";
            // 
            // porToolStripMenuItem
            // 
            porToolStripMenuItem.Name = "porToolStripMenuItem";
            porToolStripMenuItem.Size = new Size(246, 22);
            porToolStripMenuItem.Text = "Por id";
            porToolStripMenuItem.Click += porToolStripMenuItem_Click;
            // 
            // porNombreToolStripMenuItem
            // 
            porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            porNombreToolStripMenuItem.Size = new Size(246, 22);
            porNombreToolStripMenuItem.Text = "Por nombre";
            porNombreToolStripMenuItem.Click += porNombreToolStripMenuItem_Click;
            // 
            // porFechaDeCreacionToolStripMenuItem
            // 
            porFechaDeCreacionToolStripMenuItem.Name = "porFechaDeCreacionToolStripMenuItem";
            porFechaDeCreacionToolStripMenuItem.Size = new Size(246, 22);
            porFechaDeCreacionToolStripMenuItem.Text = "Por fecha de creacion";
            porFechaDeCreacionToolStripMenuItem.Click += porFechaDeCreacionToolStripMenuItem_Click;
            // 
            // porUltimaVezModificadoToolStripMenuItem
            // 
            porUltimaVezModificadoToolStripMenuItem.Name = "porUltimaVezModificadoToolStripMenuItem";
            porUltimaVezModificadoToolStripMenuItem.Size = new Size(246, 22);
            porUltimaVezModificadoToolStripMenuItem.Text = "Por ultima vez modificado";
            porUltimaVezModificadoToolStripMenuItem.Click += porUltimaVezModificadoToolStripMenuItem_Click;
            // 
            // porUltimoUsuarioQueModificoToolStripMenuItem
            // 
            porUltimoUsuarioQueModificoToolStripMenuItem.Name = "porUltimoUsuarioQueModificoToolStripMenuItem";
            porUltimoUsuarioQueModificoToolStripMenuItem.Size = new Size(246, 22);
            porUltimoUsuarioQueModificoToolStripMenuItem.Text = "Por ultimo usuario que modifico";
            porUltimoUsuarioQueModificoToolStripMenuItem.Click += porUltimoUsuarioQueModificoToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.Image = Properties.Resources.close_icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(49, 22);
            toolStripButton1.Text = "Salir";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FiltrosAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 330);
            Controls.Add(toolStrip1);
            Controls.Add(pFiltros);
            MaximizeBox = false;
            Name = "FiltrosAlmacen";
            Text = "Filtros almacen";
            pFiltros.ResumeLayout(false);
            pFiltros.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pFiltros;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton tsFiltrar;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem porToolStripMenuItem;
        private ToolStripMenuItem porNombreToolStripMenuItem;
        private ToolStripMenuItem porUltimaVezModificadoToolStripMenuItem;
        private ToolStripMenuItem porUltimoUsuarioQueModificoToolStripMenuItem;
        private ToolStripMenuItem porFechaDeCreacionToolStripMenuItem;
    }
}