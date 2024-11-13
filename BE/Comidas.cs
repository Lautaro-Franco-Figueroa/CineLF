using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Comidas
    {
        public DataTable ListaComida { get; set; }

        public Comidas() 
        {
            ListaComida = new DataTable();
            ListaComida.TableName = "Comidas";
            ListaComida.Columns.Add("Nombre");
            ListaComida.Columns.Add("Precio");
            ListaComida.Columns.Add("Cantidad", typeof(int));

            LeerArchivo();
        }
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Comidas.xml"))
            {
                ListaComida.ReadXml("Comidas.xml");
            }
        }
        public void Insert(Comida Comida)
        {
            ListaComida.Rows.Add(Comida);
            int NuevoRenglon = ListaComida.Rows.Count - 1;
            ListaComida.Rows[NuevoRenglon]["Nombre"] = Comida.Nombre;
            ListaComida.Rows[NuevoRenglon]["Precio"] = Comida.Precio;
            ListaComida.Rows[NuevoRenglon]["Cantidad"] = Comida.Cantidad;

            ListaComida.WriteXml("Comidas.xml");
        }
    }
}
