using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BaseDeDatos_SQLLite.Models;

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelLogin : UserControl
    {
        // Definimos el evento del login
        public event Action<usuario> LoginCorrecto;

        // Toolstrip deshabilitado para evitar que tengan acceso a las tablas
        // antes de iniciar sesion
        private ToolStrip ts;
        public panelLogin(ToolStrip ts)
        {
            InitializeComponent();
            this.ts = ts;
        }

        // metodo para convertir a SHA-256
        public static string ConvertirSHA256(string texto)
        {
            SHA256 sha256 = SHA256.Create();
            
            byte[] bytesTexto = Encoding.UTF8.GetBytes(texto);
            byte[] hashBytes = sha256.ComputeHash(bytesTexto);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                sb.Append(b.ToString("x2")); // Convierte a hexadecimal
            }

            return sb.ToString();
            
        }

        // Evento al hacer click en el evento del login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Separamos las variables de texto introducidas
            string usuario = txtUsuario.Text;
            string password = ConvertirSHA256(txtPassword.Text);
            string consulta = $"SELECT nombre, password FROM usuarios WHERE nombre = '{usuario}'";

            // Ejecutamos el metodo para iniciar sesion
            bool valid = DBConexion.iniciarSesion(consulta, usuario, password);

            // Verificamos
            if (valid)
            {
                string[] userValues = DBConexion.obtenerUsuario(usuario);
                usuario Usuario = new usuario();

                Usuario.nombre = userValues[0];
                Usuario.rol = userValues[1];

                LoginCorrecto?.Invoke(Usuario);

                // Obtenemos la y hora de ingreso
                DateTime fecha = DateTime.Now;

                // Actualizamos la informacion y mostramos la fecha y hora a la que se ingresa
                consulta = $"UPDATE usuarios SET fecha = '{fecha.ToString()}' WHERE nombre = '{usuario}'";
                DBConexion.ejecutarConsulta(consulta);
                MessageBox.Show($"Bienvenido {usuario}, se registro tu entrada {fecha.ToString()}");

                // habilitamos el toolstrip
                ts.Enabled = true;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intente de nuevo");
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si esta seleccionado el cuadro de texto de txtUsuario y se presiona ENTER
            // Entonces nos pasamos al cuadro de texto de txtPassword
            if (e.KeyChar == (char) Keys.Enter)
            {
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // En caso de que la tecla ENTER sea presionada despues de enviar la contraseña
            // Iniciamos sesion
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}
