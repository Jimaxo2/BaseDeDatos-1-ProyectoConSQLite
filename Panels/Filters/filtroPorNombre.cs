using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BaseDeDatos_SQLLite.Panels.Filtros
{
    public partial class filtroPorNombre : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroPorNombre(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro.Add($"p.nombre LIKE '%{txtNombreProducto.Text}%' ");
            Filtrar?.Invoke();
            //consulta += $@"p.nombre LIKE '%{txtNombreProducto.Text}%' ";
            //dt.DataSource = DBConexion.obtenerTabla(consulta);
        }
    }
}
