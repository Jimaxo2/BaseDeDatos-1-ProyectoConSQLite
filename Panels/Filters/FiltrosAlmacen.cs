using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_SQLLite.Panels.Filters
{
    public partial class FiltrosAlmacen : Form
    {
        DataGridView dt;
        public FiltrosAlmacen(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void porToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            aFiltroPorId filtro = new aFiltroPorId(dt);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            aFiltroPorNombre filtro = new aFiltroPorNombre(dt);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porUltimaVezModificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            aFiltroUltimaFecha filtro = new aFiltroUltimaFecha(dt);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porUltimoUsuarioQueModificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            aFiltroUltimoUsuario filtro = new aFiltroUltimoUsuario(dt);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porFechaDeCreacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            aFiltroFechaCreado filtro = new aFiltroFechaCreado(dt);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }
    }
}
