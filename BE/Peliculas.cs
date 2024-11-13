using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Peliculas
    {
        public DataTable ListaPelis { get; set; }

        public Peliculas()
        {
            ListaPelis = new DataTable();
            ListaPelis.TableName = "Peliculas";
            ListaPelis.Columns.Add("Nombre");
            ListaPelis.Columns.Add("Precio");
            ListaPelis.Columns.Add("Asientos", typeof(int));
            ListaPelis.Columns.Add("Horario");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Peliculas.xml"))
            {
                ListaPelis.ReadXml("Peliculas.xml");
            }
        }
       
        public void Insert(Pelicula Pelicula)
        {
            ListaPelis.Rows.Add(Pelicula);
            int NuevoRenglon = ListaPelis.Rows.Count - 1;
            ListaPelis.Rows[NuevoRenglon]["Nombre"] = Pelicula.Nombre;
            ListaPelis.Rows[NuevoRenglon]["Precio"] = Pelicula.Precio;
            ListaPelis.Rows[NuevoRenglon]["Horario"] = Pelicula.Horario;
            ListaPelis.Rows[NuevoRenglon]["Asientos"] = Pelicula.Asientos;

            ListaPelis.WriteXml("Peliculas.xml");
        }

        
    }
}
