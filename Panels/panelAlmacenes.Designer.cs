namespace BaseDeDatos_SQLLite.Panels
{
    partial class panelAlmacenes
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
            dgvAlmacenes = new DataGridView();
            btnEliminar = new Button();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            btnActualizar = new Button();
            btnRefresh = new Button();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvAlmacenes
            // 
            dgvAlmacenes.AllowUserToAddRows = false;
            dgvAlmacenes.AllowUserToDeleteRows = false;
            dgvAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlmacenes.Location = new Point(15, 102);
            dgvAlmacenes.MultiSelect = false;
            dgvAlmacenes.Name = "dgvAlmacenes";
            dgvAlmacenes.ReadOnly = true;
            dgvAlmacenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlmacenes.Size = new Size(977, 343);
            dgvAlmacenes.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(519, 470);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Enabled = false;
            btnAgregar.Location = new Point(357, 470);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.coloresunison_removebg_preview;
            pictureBox1.Location = new Point(842, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 82, 158);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 96);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 187, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 75);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox2.Image = Properties.Resources.BUHO_ABSTRACCION_EPN_big;
            pictureBox2.Location = new Point(401, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(464, 24);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 1;
            label3.Text = "Almacenes";
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(438, 470);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.refresh;
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(119, 467);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RightToLeft = RightToLeft.No;
            btnRefresh.Size = new Size(32, 29);
            btnRefresh.TabIndex = 22;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(38, 470);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 21;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // panelAlmacenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefresh);
            Controls.Add(btnFiltrar);
            Controls.Add(btnActualizar);
            Controls.Add(panel1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvAlmacenes);
            Controls.Add(pictureBox1);
            Name = "panelAlmacenes";
            Size = new Size(1006, 545);
            Load += panelAlmacenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlmacenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlmacenes;
        private Button btnEliminar;
        private Button btnAgregar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button btnActualizar;
        private Button btnRefresh;
        private Button btnFiltrar;
    }
}
