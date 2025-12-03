using BaseDeDatos_SQLLite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelManejarProductos : UserControl
    {
        public usuario Usuario;
        public int operationType;
        public Producto? Producto;
        public panelManejarProductos(usuario Usuario, int operationType, Producto? p)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            this.operationType = operationType;
            this.Producto = p;
            Thread.Sleep(100);
            if (p != null)
            {
                txtID.Text = p.id.ToString();
                txtNombre.Text = p.nombre;
                txtPrecio.Text = p.precio.ToString();
                txtCantidad.Text = p.cantidad.ToString();
                txtDepartamento.Text = p.departamento.ToString();
            }
        }

        private void panelManejarProductos_Load(object sender, EventArgs e)
        {
            // Cargar categorias
            string cb_consulta = "SELECT departamento FROM productos GROUP BY departamento";
            cbCategorias.DataSource = DBConexion.obtenerTabla(cb_consulta);
            cbCategorias.DisplayMember = "departamento";
            
            // Cargar almacenes
            string consulta = "SELECT id, nombre FROM almacenes";
            DataTable dt = new DataTable();
            dt = DBConexion.obtenerTabla(consulta);
            cbAlmacenes.DataSource = dt;
            cbAlmacenes.ValueMember = "id";
            cbAlmacenes.DisplayMember = "nombre";
            if (Producto != null)
            {
                cbCategorias.Text = Producto.departamento;
                cbAlmacenes.SelectedValue = Producto.almacen;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string consulta;
            int filas;

            try
            {

                if (txtNombre.Text == null || txtNombre.Text == "")
                {
                    MessageBox.Show("El nombre no puede estar vacio");
                    return;
                }
                if (txtDepartamento.Text == null || txtDepartamento.Text == "" && !txtDepartamento.ReadOnly)
                {
                    MessageBox.Show("La categoria no puede estar vacia");
                    return;
                }

                if (cbCategorias.Enabled)
                {
                    txtDepartamento.Text = cbCategorias.Text;
                }
                
                int.Parse(txtPrecio.Text);
                int.Parse(txtCantidad.Text);
                double.Parse(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato de numero incorrecto en precio o cantidad\n" + ex.Message);
                return;
            }

            switch (operationType)
            {
                // Caso Insert
                case 1:
                    consulta = @$"INSERT INTO productos 
                                (nombre
                                , precio
                                , cantidad
                                , departamento
                                , almacen
                                , fecha_hora_creacion
                                , ultima_modificacion
                                , ultimo_usuario) 
                                VALUES 
                                ('{txtNombre.Text}'
                                , {txtPrecio.Text}
                                , {txtCantidad.Text}
                                , '{txtDepartamento.Text}'
                                , {cbAlmacenes.SelectedValue}
                                , '{dateTime.ToString()}'
                                , '{dateTime.ToString()}'
                                , '{Usuario.nombre}' )";
                    filas = DBConexion.ejecutarConsulta(consulta);
                    MessageBox.Show("Filas afectadas: " + filas);
                    break;
                // Caso Update
                case 2:
                    consulta = $@"UPDATE productos SET
                        nombre = '{txtNombre.Text}'
                       , precio = {txtPrecio.Text}
                       , cantidad = {txtCantidad.Text}
                       , departamento = '{txtDepartamento.Text}'
                       , almacen = {cbAlmacenes.SelectedValue}
                       , ultima_modificacion = '{dateTime.ToString()}'
                       , ultimo_usuario = '{Usuario.nombre}'
                        WHERE id = {txtID.Text}";
                    filas = DBConexion.ejecutarConsulta(consulta);
                    MessageBox.Show("Filas afectadas: " + filas);
                    break;
            }
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Inicio
            panelProductos p = new panelProductos(Usuario);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);

            this.Text = "Administrar productos";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Inicio
            panelProductos p = new panelProductos(Usuario);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);

            this.Text = "Administrar productos";
        }

        private void ckbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCategoria.Checked)
            {
                txtDepartamento.ReadOnly = false;
                cbCategorias.Enabled = false;
            }
            else
            {
                txtDepartamento.Text = "";
                txtDepartamento.ReadOnly = true;
                cbCategorias.Enabled = true;
            }
        }
    }
}
