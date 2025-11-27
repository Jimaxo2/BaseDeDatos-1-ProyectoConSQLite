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

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelManejarAlmacenes : UserControl
    {
        private int operationType;
        private usuario Usuario;
        public panelManejarAlmacenes(usuario Usuario, int operationType, Almacenes a)
        {
            InitializeComponent();
            this.operationType = operationType;
            this.Usuario = Usuario;
            if (a != null)
            {
                txtID.Text = a.id.ToString();
                txtNombreAlmacen.Text = a.nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string consulta;
            int filas;
            switch (operationType)
            {
                case 1:
                    consulta = $@"INSERT INTO almacenes 
                                (nombre, fecha_hora_creacion, ultima_modificacion, ultimo_usuario) VALUES
                                ('{txtNombreAlmacen.Text}', '{dateTime.ToString()}', '{dateTime.ToString()}', '{Usuario.nombre}')";
                    filas = DBConexion.ejecutarConsulta(consulta);
                    MessageBox.Show($"Filas afectadas: {filas}");
                    break;
                case 2:
                    consulta = $@"UPDATE almacenes SET
                                nombre = '{txtNombreAlmacen.Text}'
                                , ultima_modificacion = '{dateTime.ToString()}'
                                , ultimo_usuario = '{Usuario.nombre}'
                                WHERE id = {txtID.Text}";
                    filas = DBConexion.ejecutarConsulta(consulta);
                    MessageBox.Show($"Filas afectadas: {filas}");
                    break;
            }
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Inicio
            panelAlmacenes p = new panelAlmacenes(Usuario);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            this.Controls.Clear();

            // Crear instancia del panel Inicio
            panelAlmacenes p = new panelAlmacenes(Usuario);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            this.Controls.Add(p);

            this.Text = "Administrar almacenes";
        }
    }
}
