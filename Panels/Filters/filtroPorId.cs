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
    public partial class filtroPorId : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroPorId(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El ID proporcionado no corresponde aun numero, favor de volverlo a intentar\n" + ex.Message);
                return;
            }
            
            filtro.Add($@" p.id = {txtID.Text} ");
            Filtrar?.Invoke();
        }
    }
}
