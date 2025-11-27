using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos_SQLLite.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public string departamento { get; set; }
        public int? almacen { get; set; }

        public Producto(int id, string nombre, double precio, int cantidad, string departamento, int? almacen) { 
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.departamento = departamento;
            this.almacen = almacen;
        }
    }
}
