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
    public partial class filtroPorAlmacen : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroPorAlmacen(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void filtroPorAlmacen_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT id, nombre FROM almacenes";
            DataTable dt = new DataTable();
            dt = DBConexion.obtenerTabla(consulta);
            cbAlmacenes.DataSource = dt;
            cbAlmacenes.ValueMember = "id";
            cbAlmacenes.DisplayMember = "nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro.Add($@" p.almacen = {cbAlmacenes.SelectedValue} ");
            Filtrar?.Invoke();
        }
    }
}
