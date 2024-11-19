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
            ListaPelis.TableName = "Pelicula";
            ListaPelis.Columns.Add("Nombre");
            ListaPelis.Columns.Add("Precio");
            ListaPelis.Columns.Add("Asientos", typeof(int));
            ListaPelis.Columns.Add("Horario");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Pelicula.xml"))
            {
                ListaPelis.ReadXml("Pelicula.xml");
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

            ListaPelis.WriteXml("Pelicula.xml");
        }

        public int BuscarFilaPeliculas(string Movie)
        {
            int fila = -1;

            for (int NuevoRenglon = 0; NuevoRenglon < ListaPelis.Rows.Count; NuevoRenglon++)
            {
                if (ListaPelis.Rows[NuevoRenglon]["Nombre"].ToString() == Movie)
                {
                    fila = NuevoRenglon;
                    break;
                }
            }

            return fila;
        }

        public Pelicula BuscarPelicula(string Movie, string Price, string Time, string Seat)
        {
            Pelicula Pelicula = new Pelicula(Movie, Price, Time, Seat);

            for (int i = 0; i < ListaPelis.Rows.Count; i++)
            {
                if (ListaPelis.Rows[i]["Nombre"].ToString() == Movie)
                {
                    Pelicula.Nombre = ListaPelis.Rows[i]["Nombre"].ToString();
                    Pelicula.Precio = ListaPelis.Rows[i]["Precio"].ToString();
                    Pelicula.Asientos = System.Convert.ToInt32(ListaPelis.Rows[i]["Asientos"]);
                    Pelicula.Horario = ListaPelis.Rows[i]["Horario"].ToString();
                    break;
                }
            }
            return Pelicula;
        }

        public bool BorrarPelicula(string Movie)
        {
            bool res = false;
            int fila = BuscarFilaPeliculas(Movie);

            if (fila != -1)
            {
                ListaPelis.Rows[fila].Delete();
                ListaPelis.WriteXml("Pelicula.xml");
                res = true;
            }

            return res;
        }
        public bool ModificarPelicula(Pelicula Pelicula)
        {
            bool res = false;


            ListaPelis.Rows.Add();
            int NuevoRenglon = ListaPelis.Rows.Count - 1;

            ListaPelis.Rows[NuevoRenglon]["Nombre"] = Pelicula.Nombre;
            ListaPelis.Rows[NuevoRenglon]["Precio"] = Pelicula.Precio;
            ListaPelis.Rows[NuevoRenglon]["Horario"] = Pelicula.Horario;
            ListaPelis.Rows[NuevoRenglon]["Asientos"] = Pelicula.Asientos;

            ListaPelis.WriteXml("Pelicula.xml");

            res = true;

            return res;
        }
    }
}
