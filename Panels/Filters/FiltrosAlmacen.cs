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

            // Crear instancia del panel Login
            aFiltroPorId filtro = new aFiltroPorId(dt);

            // Para que ocupe todo el espacio
            filtro.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pFiltros.Controls.Add(filtro);
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            // Crear instancia del panel Login
            aFiltroPorNombre filtro = new aFiltroPorNombre(dt);

            // Para que ocupe todo el espacio
            filtro.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pFiltros.Controls.Add(filtro);
        }

        private void porUltimaVezModificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            // Crear instancia del panel Login
            aFiltroUltimaFecha filtro = new aFiltroUltimaFecha(dt);

            // Para que ocupe todo el espacio
            filtro.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pFiltros.Controls.Add(filtro);
        }

        private void porUltimoUsuarioQueModificoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            // Crear instancia del panel Login
            aFiltroUltimoUsuario filtro = new aFiltroUltimoUsuario(dt);

            // Para que ocupe todo el espacio
            filtro.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pFiltros.Controls.Add(filtro);
        }

        private void porFechaDeCreacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            // Crear instancia del panel Login
            aFiltroFechaCreado filtro = new aFiltroFechaCreado(dt);

            // Para que ocupe todo el espacio
            filtro.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pFiltros.Controls.Add(filtro);
        }
    }
}
