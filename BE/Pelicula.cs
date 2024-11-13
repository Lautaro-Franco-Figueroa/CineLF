using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public int Asientos { get; set; }
        public string Horario { get; set; }

        public Pelicula(string nombre,
                        string precio,
                        string horario,
                        string asientos)
        {
            Nombre = nombre;
            Precio = precio;
            Horario = horario;
            Asientos = Convert.ToInt32(asientos);
        }
        
    }
}
