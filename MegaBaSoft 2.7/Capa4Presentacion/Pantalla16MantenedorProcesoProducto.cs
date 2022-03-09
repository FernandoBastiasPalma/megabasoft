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
    public partial class Pantalla16MantenedorProcesoProducto : Form
    {
        public Pantalla16MantenedorProcesoProducto()
        {
            InitializeComponent();
        }

        private Usuario usuarioSistema;

        public Pantalla16MantenedorProcesoProducto(Usuario usuario)
        {
            InitializeComponent();
            usuarioSistema = usuario;
            cargaCombobox();
        }

        private void cargaCombobox()
        {
            cmbPantalla16Producto.DropDownStyle = ComboBoxStyle.DropDownList;

            string error = "";
            NEGProductoVenta llamarTipo1 = new NEGProductoVenta();
            cmbPantalla16Producto.ValueMember = "Id";
            cmbPantalla16Producto.DisplayMember = "Nombre";
            cmbPantalla16Producto.DataSource = llamarTipo1.NEGlistarProductoVenta(out error);
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
                Pantalla11MenuAgronomo ventana = new Pantalla11MenuAgronomo();
                this.Hide();
                ventana.ShowDialog();
            }
        }

        private void Pantalla16MantenedorProcesoProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnPantalla16Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Proceso proceso = new Proceso();

                proceso.Nombre = txtPantalla16NombreProceso.Text;
                proceso.Producto = cmbPantalla16Producto.SelectedIndex+1;

                NEGProceso negProceso = new NEGProceso();
                string msjError;
                negProceso.registrarProceso(proceso, out msjError);

                if (String.IsNullOrEmpty(msjError))
                {
                    MessageBox.Show("Proceso registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
