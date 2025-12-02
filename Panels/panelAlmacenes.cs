using BaseDeDatos_SQLLite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatos_SQLLite.Panels.Filters;

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelAlmacenes : UserControl
    {
        public usuario Usuario;
        public panelAlmacenes(usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        void refrescarTabla()
        {
            string consulta = "SELECT id, nombre, fecha_hora_creacion, ultima_modificacion, ultimo_usuario FROM almacenes";
            DataTable dt = new DataTable();
            dt = DBConexion.obtenerTabla(consulta);
            dgvAlmacenes.DataSource = dt;
            //dgvAlmacenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlmacenes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void panelAlmacenes_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            if (Usuario.rol == "ADMIN" || Usuario.rol == "ALMACENES")
            {
                btnAgregar.Enabled = true;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Manejar Productos
            panelManejarAlmacenes p = new panelManejarAlmacenes(Usuario, 1, null);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que quieres eliminar el producto {dgvAlmacenes.SelectedRows[0].Cells[1].Value.ToString()}?", "Eliminar producto"
                , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string consulta = $"DELETE FROM almacenes WHERE id = {dgvAlmacenes.SelectedRows[0].Cells[0].Value}";
                int filas = DBConexion.ejecutarConsulta(consulta);
                MessageBox.Show("Filas afectadas: " + filas);
                refrescarTabla();
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Manejar Productos
            DataGridViewRow r = dgvAlmacenes.SelectedRows[0];
            Almacenes a = new Almacenes(
                int.Parse(r.Cells[0].Value.ToString())
                , r.Cells[1].Value.ToString()
                );
            panelManejarAlmacenes p = new panelManejarAlmacenes(Usuario, 2, a);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrosAlmacen f = new FiltrosAlmacen(dgvAlmacenes);
            f.ShowDialog();
        }
    }
}
