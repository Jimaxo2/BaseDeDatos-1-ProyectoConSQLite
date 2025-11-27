namespace BaseDeDatos_SQLLite.Panels.Filtros
{
    partial class Filtros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtros));
            pFiltros = new Panel();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsFiltrar = new ToolStripDropDownButton();
            porIdToolStripMenuItem = new ToolStripMenuItem();
            buscarPorNombreToolStripMenuItem = new ToolStripMenuItem();
            porCantidadToolStripMenuItem = new ToolStripMenuItem();
            porCategoriaToolStripMenuItem = new ToolStripMenuItem();
            rangoDePrecioToolStripMenuItem = new ToolStripMenuItem();
            porAlmacenToolStripMenuItem = new ToolStripMenuItem();
            porFechaDeCreacionToolStripMenuItem = new ToolStripMenuItem();
            ultimaModificacionToolStripMenuItem = new ToolStripMenuItem();
            ultimoUsuarioEnModificarToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
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
            pFiltros.TabIndex = 1;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsFiltrar, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(424, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsFiltrar
            // 
            tsFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porIdToolStripMenuItem, buscarPorNombreToolStripMenuItem, porCantidadToolStripMenuItem, porCategoriaToolStripMenuItem, rangoDePrecioToolStripMenuItem, porAlmacenToolStripMenuItem, porFechaDeCreacionToolStripMenuItem, ultimaModificacionToolStripMenuItem, ultimoUsuarioEnModificarToolStripMenuItem });
            tsFiltrar.Image = (Image)resources.GetObject("tsFiltrar.Image");
            tsFiltrar.ImageTransparentColor = Color.Magenta;
            tsFiltrar.Name = "tsFiltrar";
            tsFiltrar.Size = new Size(50, 22);
            tsFiltrar.Text = "Filtrar";
            // 
            // porIdToolStripMenuItem
            // 
            porIdToolStripMenuItem.Name = "porIdToolStripMenuItem";
            porIdToolStripMenuItem.Size = new Size(222, 22);
            porIdToolStripMenuItem.Text = "Por id";
            porIdToolStripMenuItem.Click += porIdToolStripMenuItem_Click;
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            buscarPorNombreToolStripMenuItem.Size = new Size(222, 22);
            buscarPorNombreToolStripMenuItem.Text = "Buscar por nombre";
            buscarPorNombreToolStripMenuItem.Click += buscarPorNombreToolStripMenuItem_Click;
            // 
            // porCantidadToolStripMenuItem
            // 
            porCantidadToolStripMenuItem.Name = "porCantidadToolStripMenuItem";
            porCantidadToolStripMenuItem.Size = new Size(222, 22);
            porCantidadToolStripMenuItem.Text = "Por cantidad";
            porCantidadToolStripMenuItem.Click += porCantidadToolStripMenuItem_Click;
            // 
            // porCategoriaToolStripMenuItem
            // 
            porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            porCategoriaToolStripMenuItem.Size = new Size(222, 22);
            porCategoriaToolStripMenuItem.Text = "Por categoria";
            porCategoriaToolStripMenuItem.Click += porCategoriaToolStripMenuItem_Click;
            // 
            // rangoDePrecioToolStripMenuItem
            // 
            rangoDePrecioToolStripMenuItem.Name = "rangoDePrecioToolStripMenuItem";
            rangoDePrecioToolStripMenuItem.Size = new Size(222, 22);
            rangoDePrecioToolStripMenuItem.Text = "Rango de precio";
            rangoDePrecioToolStripMenuItem.Click += rangoDePrecioToolStripMenuItem_Click;
            // 
            // porAlmacenToolStripMenuItem
            // 
            porAlmacenToolStripMenuItem.Name = "porAlmacenToolStripMenuItem";
            porAlmacenToolStripMenuItem.Size = new Size(222, 22);
            porAlmacenToolStripMenuItem.Text = "Por almacen";
            porAlmacenToolStripMenuItem.Click += porAlmacenToolStripMenuItem_Click;
            // 
            // porFechaDeCreacionToolStripMenuItem
            // 
            porFechaDeCreacionToolStripMenuItem.Name = "porFechaDeCreacionToolStripMenuItem";
            porFechaDeCreacionToolStripMenuItem.Size = new Size(222, 22);
            porFechaDeCreacionToolStripMenuItem.Text = "Por fecha de creacion";
            porFechaDeCreacionToolStripMenuItem.Click += porFechaDeCreacionToolStripMenuItem_Click;
            // 
            // ultimaModificacionToolStripMenuItem
            // 
            ultimaModificacionToolStripMenuItem.Name = "ultimaModificacionToolStripMenuItem";
            ultimaModificacionToolStripMenuItem.Size = new Size(222, 22);
            ultimaModificacionToolStripMenuItem.Text = "Ultima Modificacion";
            ultimaModificacionToolStripMenuItem.Click += ultimaModificacionToolStripMenuItem_Click;
            // 
            // ultimoUsuarioEnModificarToolStripMenuItem
            // 
            ultimoUsuarioEnModificarToolStripMenuItem.Name = "ultimoUsuarioEnModificarToolStripMenuItem";
            ultimoUsuarioEnModificarToolStripMenuItem.Size = new Size(222, 22);
            ultimoUsuarioEnModificarToolStripMenuItem.Text = "Ultimo usuario en modificar";
            ultimoUsuarioEnModificarToolStripMenuItem.Click += ultimoUsuarioEnModificarToolStripMenuItem_Click;
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
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(105, 22);
            toolStripButton2.Text = "Reiniciar filtros";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // Filtros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 330);
            Controls.Add(toolStrip1);
            Controls.Add(pFiltros);
            MaximizeBox = false;
            Name = "Filtros";
            Text = "Filtros";
            pFiltros.ResumeLayout(false);
            pFiltros.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pFiltros;
        private ToolStrip toolStrip1;
        private Label label1;
        private ToolStripDropDownButton tsFiltrar;
        private ToolStripMenuItem buscarPorNombreToolStripMenuItem;
        private ToolStripMenuItem porCantidadToolStripMenuItem;
        private ToolStripMenuItem porCategoriaToolStripMenuItem;
        private ToolStripMenuItem rangoDePrecioToolStripMenuItem;
        private ToolStripMenuItem porAlmacenToolStripMenuItem;
        private ToolStripMenuItem ultimaModificacionToolStripMenuItem;
        private ToolStripMenuItem ultimoUsuarioEnModificarToolStripMenuItem;
        private ToolStripMenuItem porIdToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem porFechaDeCreacionToolStripMenuItem;
        private ToolStripButton toolStripButton2;
    }
}