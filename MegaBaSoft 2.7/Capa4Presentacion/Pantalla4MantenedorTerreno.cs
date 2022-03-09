using Capa1Entidades;
using Capa3Negocio;
using Clases;
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
    public partial class Pantalla4MantenedorTerreno : Form
    {
        private Usuario usuarioSistema;

        public Pantalla4MantenedorTerreno()
        {
            InitializeComponent();
        }

        public Pantalla4MantenedorTerreno(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
        }

        private void btnPantalla4Volver_Click(object sender, EventArgs e)
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

        private void btnPantalla4Guardar_Click(object sender, EventArgs e) //BOTON GUARDAR
        {
            try
            {
                Terreno terreno = new Terreno();

                terreno.Codigo = txtPantalla4Codigo.Text;
                terreno.Nombre = txtPantalla4Numero.Text;
                terreno.Descripcion = txtPantalla4Descripcion.Text;

                NEGTerreno negTerreno = new NEGTerreno();
                string msjError;
                negTerreno.registrarTerreno(terreno, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Terreno registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla4Modificar_Click(object sender, EventArgs e) //BOTON MODIFICAR
        {
            try
            {
                Terreno terreno = new Terreno();

                terreno.Codigo = txtPantalla4Codigo.Text;
                terreno.Nombre = txtPantalla4Numero.Text;
                terreno.Descripcion = txtPantalla4Descripcion.Text;

                NEGTerreno negTerreno = new NEGTerreno();
                string msjError;
                negTerreno.modificarTerreno(terreno, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Terreno modificado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla4Eliminar_Click(object sender, EventArgs e) //BOTON ELIMINAR
        {
            try
            {
                Terreno terreno = new Terreno();

                terreno.Codigo = txtPantalla4Codigo.Text;

                NEGTerreno negTerreno = new NEGTerreno();
                string msjError;
                negTerreno.eliminarTerreno(terreno, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Terreno eliminado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla4Buscar_Click(object sender, EventArgs e) //BOTON BUSCAR
        {
            Terreno terreno = new Terreno();

            terreno.Codigo = txtPantalla4Codigo.Text;
            terreno.Nombre = txtPantalla4Numero.Text;
            terreno.Descripcion = txtPantalla4Descripcion.Text;

            string msjValida = "";
            if (txtPantalla4Codigo.Text != "")
            {

                terreno.Codigo = txtPantalla4Codigo.Text;

                List<Terreno> listaTerreno = new List<Terreno>();

                NEGTerreno negTerreno = new NEGTerreno();
                listaTerreno = negTerreno.NEGlistarTerrenoPorCodigo("Codigo",terreno,out msjValida);

                if (msjValida.Equals(""))
                {
                    txtPantalla4Codigo.Text = (listaTerreno[0].Codigo).ToString();
                    txtPantalla4Numero.Text = (listaTerreno[0].Nombre).ToString();
                    txtPantalla4Descripcion.Text = (listaTerreno[0].Descripcion).ToString();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error durante la Busqueda: " + msjValida, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Pantalla4MantenedorTerreno_Load(object sender, EventArgs e)
        {

        }
    }

}
