using Capa1Entidades;
using Capa3Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa4Presentacion
{
    public partial class Pantalla9MantenedorActividad : Form
    {
        private Usuario usuarioSistema;

        public Pantalla9MantenedorActividad()
        {
            InitializeComponent();
        }

        public Pantalla9MantenedorActividad(Usuario usuario)
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

        private void btnPantalla9Guardar_Click(object sender, EventArgs e)
        {
            try{ 

                Actividad actividad = new Actividad();

                actividad.Codigo = txtPantalla9codigo.Text;
                actividad.Nombre = txtPantalla9Nombre.Text;
                actividad.Descripcion = txtPantalla9Descripcion.Text;

                NEGActividad negActividad = new NEGActividad();
                string msjError;
                negActividad.registrarActividad(actividad, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Actividad registrada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla9Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad actividad = new Actividad();

                actividad.Codigo = txtPantalla9codigo.Text;
                actividad.Nombre = txtPantalla9Nombre.Text;
                actividad.Descripcion = txtPantalla9Descripcion.Text;

                NEGActividad negActividad = new NEGActividad();
                string msjError;
                negActividad.modificarActividad(actividad, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("actividad modificada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla9Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad actividad = new Actividad();

                actividad.Codigo = txtPantalla9codigo.Text;

                NEGActividad negActividad= new NEGActividad();
                string msjError;
                negActividad.eliminarActividad(actividad, out msjError);

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

        private void btnPantalla9Buscar_Click(object sender, EventArgs e) 
        {
            try
            {
                Actividad actividad = new Actividad();

                actividad.Codigo = txtPantalla9codigo.Text;
                actividad.Nombre = txtPantalla9Nombre.Text;
                actividad.Descripcion = txtPantalla9Descripcion.Text;

                string msjValida = "";
                if (txtPantalla9codigo.Text != "")
                {
                    actividad.Codigo = txtPantalla9codigo.Text;

                    List<Actividad> listaActividad = new List<Actividad>();

                    NEGActividad negActividad = new NEGActividad();
                    listaActividad = negActividad.NEGlistaractividadPorConsulta("Codigo", actividad, out msjValida);

                    if (msjValida.Equals(""))
                    {
                        txtPantalla9codigo.Text = (listaActividad[0].Codigo).ToString();
                        txtPantalla9Nombre.Text = (listaActividad[0].Nombre).ToString();
                        txtPantalla9Descripcion.Text = (listaActividad[0].Descripcion).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error durante la Busqueda: " + msjValida, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Actualización Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txtPantalla9codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pantalla9MantenedorActividad_Load(object sender, EventArgs e)
        {

        }
    }
}
