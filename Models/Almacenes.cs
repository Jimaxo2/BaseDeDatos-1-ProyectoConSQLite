using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos_SQLLite.Models
{
    public class Almacenes
    {
        public int id {  get; set; }
        public string nombre { get; set; }

        public Almacenes(int id, string nombre) { 
            this.id = id;
            this.nombre = nombre;
        }
    }
}
