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
    public partial class aFiltroPorId : UserControl
    {
        DataGridView dt;
        public aFiltroPorId(DataGridView dt)
        {
            InitializeComponent();
            this.dt = dt;
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
	                        WHERE id = {txtId.Text}";
            dt.DataSource = DBConexion.obtenerTabla(consulta);
        }
    }
}
