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
    public partial class aFiltroUltimaFecha : UserControl
    {
        DataGridView dt;
        public aFiltroUltimaFecha(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Fecha: {mcCalendario.SelectionStart.ToShortDateString()}");
            string consulta = $@"SELECT 
	                        id
	                        , nombre
                            , fecha_hora_creacion
	                        , ultima_modificacion
	                        , ultimo_usuario
	                        FROM almacenes
				            WHERE ultima_modificacion LIKE '{mcCalendario.SelectionStart.ToShortDateString()}%'";
            dt.DataSource = DBConexion.obtenerTabla(consulta);
        }
    }
}
