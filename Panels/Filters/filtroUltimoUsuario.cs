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
    public partial class filtroUltimoUsuario : UserControl
    {
        List<string> filtro;
        public event Action Filtrar;
        public filtroUltimoUsuario(List<string> filtro, Action Filtrar)
        {
            InitializeComponent();
            this.filtro = filtro;
            this.Filtrar = Filtrar;
        }

        private void filtroUltimoUsuario_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT id, nombre, rol FROM usuarios WHERE rol = 'ADMIN' OR rol = 'PRODUCTOS'";
            cbUsuarios.DataSource = DBConexion.obtenerTabla(consulta);
            cbUsuarios.ValueMember = "id";
            cbUsuarios.DisplayMember = "nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro.Add($@" p.ultimo_usuario = '{cbUsuarios.Text}' ");
            Filtrar?.Invoke();
        }
    }
}
