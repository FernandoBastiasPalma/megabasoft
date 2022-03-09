using Capa1Entidades;
using Capa3Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa4Presentacion
{
    public partial class Pantalla7MantenedorProductoVenta : Form
    {
        public Pantalla7MantenedorProductoVenta()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla7MantenedorProductoVenta(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioSistema.Id_permiso == 4)
            {
                Pantalla13MenuSistema ventana = new Pantalla13MenuSistema(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
            else if (usuarioSistema.Id_permiso == 2)
            {
                Pantalla11MenuAgronomo ventana = new Pantalla11MenuAgronomo(usuarioSistema);
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void btnPantalla3Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoVenta producto = new ProductoVenta();

                producto.Codigo = txtPantalla7Codigo.Text;
                producto.Nombre = txtPantalla7Nombre.Text;


                NEGProductoVenta negProducto = new NEGProductoVenta();
                string msjError;
                negProducto.Registrarproducto(producto, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("producto registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPantalla3Run_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPantalla4Modificar_Click(object sender, EventArgs e) //BOTON MODIFICAR
        {
            try
            {
                ProductoVenta producto = new ProductoVenta();

                producto.Codigo = txtPantalla7Codigo.Text;
                producto.Nombre = txtPantalla7Nombre.Text;

                NEGProductoVenta negProducto= new NEGProductoVenta();
                string msjError;
                negProducto.modificarProducto(producto, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Producto modificado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPantalla3Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoVenta productoVenta = new ProductoVenta();

                productoVenta.Codigo = txtPantalla7Codigo.Text;
                productoVenta.Nombre = txtPantalla7Nombre.Text;

                NEGProductoVenta negProductoVenta = new NEGProductoVenta();
                string msjError;
                negProductoVenta.modificarProducto(productoVenta, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Producto modificado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPantalla3Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoVenta producto = new ProductoVenta();

                producto.Codigo = txtPantalla7Codigo.Text;

                NEGProductoVenta negProductoV = new NEGProductoVenta();
                string msjError;
                negProductoV.eliminarProducto(producto, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("producto eliminado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msjError, "Registro Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eliminacion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPantalla7Buscar_Click(object sender, EventArgs e)
        {
            ProductoVenta producto = new ProductoVenta();

            producto.Codigo = txtPantalla7Codigo.Text;
            producto.Nombre = txtPantalla7Nombre.Text;
         

            string msjValida = "";
            if (txtPantalla7Codigo.Text != "")
            {

                producto.Codigo = txtPantalla7Codigo.Text;

                List<ProductoVenta> listaproducto = new List<ProductoVenta>();

                NEGProductoVenta negProducto = new NEGProductoVenta();
                listaproducto = negProducto.NEGlistarProductoPorCodigo("Codigo",producto, out msjValida);

                if (msjValida.Equals(""))
                {
                    txtPantalla7Codigo.Text = (listaproducto[0].Codigo).ToString();
                    txtPantalla7Nombre.Text = (listaproducto[0].Nombre).ToString();
                    
                }
                else
                {
                    MessageBox.Show("Ocurrio un error durante la Busqueda: " + msjValida, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Pantalla7MantenedorProductoVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
