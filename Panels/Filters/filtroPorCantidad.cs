using BaseDeDatos_SQLLite.Models;
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
    public partial class filtroPorCantidad : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroPorCantidad(List<string> filtro, Action Filtrar)
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
                int.Parse(txtCantidadMenor.Text);
            }
            catch (FormatException ex)
            {
                txtCantidadMenor.Text = "0";
                txtCantidadMayor.Text = "";
                MessageBox.Show($"{txtCantidadMenor.Text} NO es un numero, favor de introducir un numero\n{ex.Message}");
                return;
            }

            if (txtCantidadMenor.Text == null || txtCantidadMenor.Text == "") { txtCantidadMenor.Text = "0"; }
            if (txtCantidadMayor.Text == null || txtCantidadMayor.Text == "")
            {
                filtro.Add($@" p.cantidad BETWEEN {txtCantidadMenor.Text} AND (SELECT MAX(cantidad) FROM productos) ");
            }
            else
            {
                filtro.Add($@" p.cantidad BETWEEN {txtCantidadMenor.Text} AND {txtCantidadMayor.Text} ");
            }
            Filtrar?.Invoke();
        }
    }
}
