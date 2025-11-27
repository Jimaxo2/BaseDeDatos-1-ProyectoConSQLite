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
    public partial class filtroRangoPrecio : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroRangoPrecio(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Controlamos que los TextBox tengan caracteres distintos de numeros
            try
            {
                int.Parse(txtPrecioMenor.Text);
            }
            catch (FormatException ex)
            {
                txtPrecioMenor.Text = "0";
                txtPrecioMayor.Text = "";
                MessageBox.Show($"{txtPrecioMenor.Text} o {txtPrecioMayor.Text} NO es un numero, favor de introducir un numero\n{ex.Message}");
                return;
            }

            if (txtPrecioMayor.Text == null || txtPrecioMayor.Text == "")
            {
                if (txtPrecioMenor.Text == null || txtPrecioMenor.Text == "") { txtPrecioMenor.Text = "0"; }

                filtro.Add($@" precio BETWEEN {txtPrecioMenor.Text} AND (SELECT MAX(precio) FROM productos) ");
            }
            else
            {
                filtro.Add($@" precio BETWEEN {txtPrecioMenor.Text} AND {txtPrecioMayor.Text} ");
            }
            Filtrar?.Invoke();
        }
    }
}
