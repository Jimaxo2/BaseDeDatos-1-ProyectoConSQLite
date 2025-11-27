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
    public partial class aFiltroUltimoUsuario : UserControl
    {
        DataGridView dt;
        public aFiltroUltimoUsuario(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void aFiltroUltimoUsuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT id, nombre, rol FROM usuarios WHERE rol = 'ADMIN' OR rol = 'ALMACENES'";
            cbUsuarios.DataSource = DBConexion.obtenerTabla(consulta);
            cbUsuarios.ValueMember = "id";
            cbUsuarios.DisplayMember = "nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = $@"SELECT 
	                        id
	                        , nombre
                            , fecha_hora_creacion
	                        , ultima_modificacion
	                        , ultimo_usuario
	                        FROM almacenes
	                        WHERE ultimo_usuario = '{cbUsuarios.Text}'";
            dt.DataSource = DBConexion.obtenerTabla(consulta);
        }
    }
}
