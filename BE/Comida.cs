using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Comida
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public int Cantidad { get; set; }

        public Comida(string nombre,
                      string precio,
                      string cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = Convert.ToInt32(cantidad);
        }
    }
}
