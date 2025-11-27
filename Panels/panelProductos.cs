using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatos_SQLLite.Models;
using BaseDeDatos_SQLLite.Panels;

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelProductos : UserControl
    {
        public usuario Usuario;
        public string consulta = @"SELECT 
                                p.id
                                , p.nombre
                                , p.cantidad
                                , p.precio
                                , p.departamento
                                , a.id AS almacen_id
                                , a.nombre AS almacen
                                , p.fecha_hora_creacion
                                , p.ultima_modificacion
                                , p.ultimo_usuario 
                                FROM productos AS p
                                LEFT JOIN almacenes a ON p.almacen = a.id";
        public panelProductos(usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        // Metodo para refrescar la tabla cada que se llama
        void refrescarTabla()
        {
            consulta = @"SELECT 
                                p.id
                                , p.nombre
                                , p.cantidad
                                , p.precio
                                , p.departamento
                                , a.id AS almacen_id
                                , a.nombre AS almacen
                                , p.fecha_hora_creacion
                                , p.ultima_modificacion
                                , p.ultimo_usuario 
                                FROM productos AS p
                                LEFT JOIN almacenes a ON p.almacen = a.id";
            DataTable dt = new DataTable();
            dt = DBConexion.obtenerTabla(consulta);
            dgvProductos.DataSource = dt;
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            if (Usuario.rol == "ADMIN" || Usuario.rol == "PRODUCTOS")
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
            panelManejarProductos p = new panelManejarProductos(Usuario, 1, null);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que quieres eliminar el producto {dgvProductos.SelectedRows[0].Cells[1].Value.ToString()}?", "Eliminar producto"
                , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string consulta = @$"DELETE FROM productos WHERE id = {dgvProductos.SelectedRows[0].Cells[0].Value}";
                int filas = DBConexion.ejecutarConsulta(consulta);
                MessageBox.Show("Filas afectadas: " + filas);

                refrescarTabla();
            } else
            {
                MessageBox.Show("Operación cancelada");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int almacenId;
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Manejar Productos
            DataGridViewRow row = dgvProductos.SelectedRows[0];

            try
            {
                // En caso de que el departamento sea un null, directamente le asignamos un 0
                almacenId = int.Parse(row.Cells[5].Value.ToString());

            } catch (FormatException ex)
            {
                almacenId = 0;
            }

            Producto p = new Producto(
                int.Parse(row.Cells[0].Value.ToString())
                , row.Cells[1].Value.ToString()
                , double.Parse(row.Cells[3].Value.ToString())
                , int.Parse(row.Cells[2].Value.ToString())
                , row.Cells[4].Value.ToString()
                , almacenId
                );
            panelManejarProductos pa = new panelManejarProductos(Usuario, 2, p);
            pa.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(pa);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtros.Filtros f = new Filtros.Filtros(dgvProductos, consulta);
            f.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refrescarTabla();
        }
    }
}
