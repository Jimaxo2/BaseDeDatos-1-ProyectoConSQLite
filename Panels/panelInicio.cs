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

namespace BaseDeDatos_SQLLite.Panels
{
    public partial class panelInicio : UserControl
    {
        public usuario Usuario { get; set; }
        public panelInicio(usuario Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            labelUsuarioActivo.Text += Usuario.nombre;
        }
    }
}
