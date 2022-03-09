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
    public partial class Pantalla6MantenedorMateriaPrima : Form
    {
        public Pantalla6MantenedorMateriaPrima()
        {
            InitializeComponent();
        }

        private void cargaCombobox()
        {
            cmbPantalla6UnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGMateriaPrima llamarTipoP = new NEGMateriaPrima();
            cmbPantalla6UnidadMedida.ValueMember = "Id";
            cmbPantalla6UnidadMedida.DisplayMember = "Nombre";
            cmbPantalla6UnidadMedida.DataSource = llamarTipoP.NEGlistarUnidadMedida(out error);
        }

        private Usuario usuarioSistema;

        public Pantalla6MantenedorMateriaPrima(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pantalla6MantenedorMateriaPrima_Load(object sender, EventArgs e)
        {

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

        private void btnPantalla6Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima Materia = new MateriaPrima();

                Materia.Codigo = txtPantalla6Codigo.Text;
                Materia.Nombre = txtPantalla6Nombre.Text;
                Materia.Descripcion = txtPantalla6Descripcion.Text;
                Materia.Cantidad = int.Parse(txtPantalla6Cantidad.Text);
                Materia.Stock = int.Parse(txtPantalla6Stock.Text);
                Materia.Costo = int.Parse(txtPantalla6costo.Text);
                Materia.UnidadMedida = (int)cmbPantalla6UnidadMedida.SelectedValue;

                NEGMateriaPrima negMateria = new NEGMateriaPrima();
                string msjError;
                negMateria.registrarMateria(Materia, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Materia prima ha registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla6Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima materia = new MateriaPrima();

                materia.Codigo = txtPantalla6Codigo.Text;
                materia.Nombre = txtPantalla6Nombre.Text;
                materia.Descripcion = txtPantalla6Descripcion.Text;
                materia.Cantidad = int.Parse(txtPantalla6Cantidad.Text);
                materia.Stock = int.Parse(txtPantalla6Stock.Text);
                materia.Costo = int.Parse(txtPantalla6costo.Text);
                materia.UnidadMedida = cmbPantalla6UnidadMedida.SelectedIndex+1;

                NEGMateriaPrima negMateria = new NEGMateriaPrima();
                string msjError;
                negMateria.actualizarMateria(materia, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Materia modificada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla6Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima materia = new MateriaPrima();

                materia.Codigo = txtPantalla6Codigo.Text;

                NEGMateriaPrima negMateria = new NEGMateriaPrima();
                string msjError;
                negMateria.eliminarMateria(materia, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Materia eliminada correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPantalla3Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima materiaPrima = new MateriaPrima();

                materiaPrima.Codigo = txtPantalla6Codigo.Text;
                materiaPrima.Nombre = txtPantalla6Nombre.Text;
                materiaPrima.Descripcion = txtPantalla6Descripcion.Text;
                materiaPrima.Cantidad = int.Parse(txtPantalla6Cantidad.Text);
                materiaPrima.Stock = int.Parse(txtPantalla6Stock.Text);
                materiaPrima.Costo = int.Parse(txtPantalla6costo.Text);
                materiaPrima.UnidadMedida = cmbPantalla6UnidadMedida.SelectedIndex;

                string msjValida = "";
                if (txtPantalla6Codigo.Text != "" )
                {

                    materiaPrima.Codigo = txtPantalla6Codigo.Text;

                    List<MateriaPrima> listaMateria = new List<MateriaPrima>();

                    NEGMateriaPrima negMateria = new NEGMateriaPrima();
                    listaMateria = negMateria.NEGlistarMateriaPrimaPorCodigo("Codigo",materiaPrima, out msjValida);

                    if (msjValida.Equals(""))
                    {
                        
                        txtPantalla6Codigo.Text = (listaMateria[0].Codigo).ToString();
                        txtPantalla6Nombre.Text = (listaMateria[0].Nombre).ToString();
                        txtPantalla6Descripcion.Text = (listaMateria[0].Descripcion).ToString();
                        txtPantalla6Cantidad.Text = (listaMateria[0].Cantidad).ToString();
                        txtPantalla6Stock.Text = (listaMateria[0].Stock).ToString();
                        txtPantalla6costo.Text = (listaMateria[0].Costo).ToString();
                        cmbPantalla6UnidadMedida.Text = (listaMateria[0].UnidadMedida).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error durante la Busqueda: " + msjValida, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Busqueda Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
