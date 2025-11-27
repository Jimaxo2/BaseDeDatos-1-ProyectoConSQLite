using BaseDeDatos_SQLLite.Panels.Filters;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_SQLLite.Panels.Filtros
{
    public partial class Filtros : Form
    {
        public DataGridView dt;
        public string consulta;
        public List<string> filtro = new List<string>();
        public Filtros(DataGridView dgv, string consulta)
        {
            InitializeComponent();
            dt = dgv;
            this.consulta = consulta;
        }

        void Filtrar()
        {
            string consulta = this.consulta;
            if (filtro.Count > 0)
            {
                consulta += " WHERE " + string.Join(" AND ", filtro);
                dt.DataSource = DBConexion.obtenerTabla(consulta);
            }
            else
            {
                MessageBox.Show("No hay filtros por aplicar");
            }

        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroPorNombre f = new filtroPorNombre(this.filtro, Filtrar);

            f.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(f);
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroPorCategoria filtro = new filtroPorCategoria(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void rangoDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroRangoPrecio filtro = new filtroRangoPrecio(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroPorAlmacen filtro = new filtroPorAlmacen(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroPorCantidad filtro = new filtroPorCantidad(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void ultimaModificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroUltimaFecha filtro = new filtroUltimaFecha(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void ultimoUsuarioEnModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroUltimoUsuario filtro = new filtroUltimoUsuario(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroPorId filtro = new filtroPorId(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void porFechaDeCreacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFiltros.Controls.Clear();

            filtroFechaCreado filtro = new filtroFechaCreado(this.filtro, Filtrar);

            filtro.Dock = DockStyle.Fill;

            pFiltros.Controls.Add(filtro);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            filtro.Clear();
            dt.DataSource = DBConexion.obtenerTabla(consulta);
        }
    }
}
