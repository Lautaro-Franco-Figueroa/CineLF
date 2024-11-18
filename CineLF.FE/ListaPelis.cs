using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CineLF.FE
{
    public partial class ListaPelis : Form
    {
        private Peliculas Peliculas = new Peliculas();
        private Comidas Comidas = new Comidas();
        public ListaPelis()
        {
            InitializeComponent();
            DGVPelis.DataSource = Peliculas.ListaPelis;
            DGVFood.DataSource = Comidas.ListaComida;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Pelicula Pelicula = new Pelicula(txtName.Text, txtPrecio.Text, txtSillas.Text, txtTime.Text);
            Peliculas.Insert(Pelicula);
        }
        private void btAceptarFood_Click(object sender, EventArgs e)
        {
            Comida Comida = new Comida(txtNameFood.Text, txtPrecioFood.Text, txtCantidad.Text);
            Comidas.Insert(Comida);
        }

        private void btMu_Click(object sender, EventArgs e)
        {
            ShowPelis();
        }
        private void btFood_Click(object sender, EventArgs e)
        {
            ShowFood();
        }
        private void ShowFood()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            txtName.Visible = false;
            txtPrecio.Visible = false;
            txtSillas.Visible = false;
            txtTime.Visible = false;
            txtCantidad.Visible = true;
            txtNameFood.Visible = true;
            txtPrecioFood.Visible = true;
            btAceptar.Visible = false;
            btAceptarFood.Visible = true;
            DGVPelis.Visible = false;
            DGVFood.Visible = true;
        }
        private void ShowPelis()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            txtName.Visible = true;
            txtPrecio.Visible = true;
            txtSillas.Visible = true;
            txtTime.Visible = true;
            txtCantidad.Visible = false;
            txtNameFood.Visible = false;
            txtPrecioFood.Visible = false;
            btAceptar.Visible = true;
            btAceptarFood.Visible = false;
            DGVPelis.Visible = true;
            DGVFood.Visible = false;
        }

        

        private void btBuy_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtName.Visible = false;
            txtPrecio.Visible = false;
            txtSillas.Visible = false;
            txtTime.Visible = false;
            txtCantidad.Visible = false;
            txtNameFood.Visible = false;
            txtPrecioFood.Visible = false;
            btAceptar.Visible = false;
            btAceptarFood.Visible = false;
            DGVPelis.Visible = false;
            DGVFood.Visible = false;
        }

        private void btBuscarPeli_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrecio.Text = "";
            txtTime.Text = "";
            txtSillas.Text = "";

            Pelicula pelicula = new Pelicula(txtName.Text, txtPrecio.Text, txtTime.Text, txtSillas.Text);

            pelicula = Peliculas.BuscarPelicula(txtName.Text, txtPrecio.Text, txtTime.Text, txtSillas.Text);

            if (pelicula.Nombre != null)
            {
                txtName.Text = pelicula.Nombre.ToUpper();
                txtPrecio.Text = pelicula.Precio;
                txtSillas.Text = pelicula.Horario;
                txtTime.Text = pelicula.Asientos.ToString();
            }

            txtSillas.Focus();
            txtSillas.SelectAll();
        }

        private void btBorrarPeli_Click(object sender, EventArgs e)
        {
            bool res = Peliculas.BorrarPelicula(txtName.Text.ToUpper());

            if (res)
            {
                LimpiarPantalla();
            }
            else
            {
                txtName.Focus();
                txtName.SelectAll();
            }
        }

        private void LimpiarPantalla()
        {
            txtName.Text = "";
            txtPrecio.Text = "";
            txtTime.Text = "";
            txtSillas.Text = "";

            txtName.Focus();
        }
    }
}
