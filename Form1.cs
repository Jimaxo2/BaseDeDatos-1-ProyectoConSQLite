using BaseDeDatos_SQLLite.Models;
using BaseDeDatos_SQLLite.Panels;
using Microsoft.VisualBasic.Logging;

namespace BaseDeDatos_SQLLite
{
    public partial class Form1 : Form
    {
        private usuario? Usuario;
        public Form1()
        {
            InitializeComponent();
        }
        // Evento que se dispara unicamente cuando el login es exitoso
        private void LoginExitoso(usuario Usuario)
        {
            // Guardas el usuario en el Form
            this.Usuario = Usuario;

            // Luego puedes cambiar de vista
            pDisplay.Controls.Clear();

            panelInicio inicio = new panelInicio(Usuario);
            inicio.Dock = DockStyle.Fill;

            pDisplay.Controls.Add(inicio);

            // Opcional: habilitar cosas del Form
            toolStrip1.Enabled = true;
            toolStrip1.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Login
            panelLogin Login = new panelLogin(toolStrip1);

            // Este es el evento que se disparara una vez se acceda correctamente
            Login.LoginCorrecto += LoginExitoso;

            // Para que ocupe todo el espacio
            Login.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(Login);
            this.Text = "Iniciar sesion";
        }

        private void inicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Inicio

            panelInicio Inicio = new panelInicio(Usuario);
            Inicio.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(Inicio);

            this.Text = "Administrador de productos";
        }

        private void almacenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Inicio
            panelAlmacenes a = new panelAlmacenes(Usuario);
            a.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(a);

            this.Text = "Administrar almacenes";
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Inicio
            panelProductos p = new panelProductos(Usuario);
            p.Dock = DockStyle.Fill; // Para que ocupe todo el espacio

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(p);

            this.Text = "Administrar productos";
        }

        private void dspCatalogos_EnabledChanged(object sender, EventArgs e)
        {
            if (dspCatalogos.Enabled)
            {
                this.Text = "Administrador de productos";
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restablecemos al usuario y deshabilitamos el toolstrip
            Usuario = null;
            toolStrip1.Enabled = false;
            toolStrip1.Visible = false;

            // Limpiar el panel por si acaso
            pDisplay.Controls.Clear();

            // Crear instancia del panel Login
            panelLogin Login = new panelLogin(toolStrip1);

            // Este es el evento que se disparara una vez se acceda correctamente
            Login.LoginCorrecto += LoginExitoso;

            // Para que ocupe todo el espacio
            Login.Dock = DockStyle.Fill;

            // Agregarlo al panel contenedor
            pDisplay.Controls.Add(Login);
            this.Text = "Iniciar sesion";

        }
    }
}
