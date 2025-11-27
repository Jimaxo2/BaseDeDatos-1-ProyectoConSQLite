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
    public partial class filtroUltimaFecha : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroUltimaFecha(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Fecha: {mcCalendario.SelectionStart.ToShortDateString()}");
            
            filtro.Add($@" p.ultima_modificacion LIKE '{mcCalendario.SelectionStart.ToShortDateString()}%' ");
            Filtrar?.Invoke();
        }
    }
}
