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
    public partial class filtroPorCategoria : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroPorCategoria(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void filtroPorCategoria_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT departamento FROM productos GROUP BY departamento";
            cbCategoria.DataSource = DBConexion.obtenerTabla(consulta);
            cbCategoria.DisplayMember = "departamento";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            filtro.Add($@" p.departamento = '{cbCategoria.Text}' ");
            Filtrar?.Invoke();
            //consulta += $@" p.departamento = '{cbCategoria.Text}' ";
        }

    }
}
